using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace PushBullet
{
  public partial class NewAPI : Form
  {
    #region Members
    public static CookieContainer cookieContainer = new CookieContainer();
    private string HOST = "https://api.pushbullet.com";
    private string csrf = "";
    private JArray devices;
    private JArray shared_devices;
    private bool hideMe;
    private string apikey = "";
    private string version = "1.3.2";
    private WebClient wc;
    private List<TextBox> textBoxes = new List<TextBox>();
    private List<Label> listLabels = new List<Label>();
    #endregion

    public NewAPI()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Do we want to open normally or in tray?
      string[] args = Environment.GetCommandLineArgs();
      foreach (string arg in args) {
        if (arg == "/tray") {
          hideMe = true;
        }
      }
      if (args.Length == 4) {
        QuickPush(args[1], args[2], args[3]);
        hideMe = true;
      }

      Thread updateThread = new Thread(CheckUpdate);
      updateThread.Start();

      this.Text = "Pushbullet Desktop " + version;

      //Create an authenticated webclient if apikey already supplied
      apikey = Properties.Settings.Default.APIKey;
      if (apikey != "") {
        wc = AuthenticatedWebClient();
      }

      tabPage4.AutoScroll = true;


      #region List Item
      //Add the first list item
      Label label = new Label();
      label.Location = new Point(listLabel.Location.X, 35);
      label.Text = "Note item:";
      label.Size = new Size(55, 13);
      TextBox textBox = new TextBox();
      textBox.Size = listTitle.Size;
      textBox.Location = new Point(listTitle.Location.X, 35);

      textBoxes.Add(textBox);
      listLabels.Add(label);

      tabPage4.Controls.Add(label);
      tabPage4.Controls.Add(textBox);
      #endregion
    }

    public WebClient AuthenticatedWebClient()
    {
      WebClient wc = new WebClient();
      wc.Proxy = null;
      string authEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(apikey + ":"));
      wc.Headers[HttpRequestHeader.UserAgent] = "Pushbullet.Desktop.Application(" + version + ")";
      wc.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", authEncoded);

      return wc;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      base.OnFormClosing(e);

      //Close application for real if windows is shutting down
      if (e.CloseReason == CloseReason.WindowsShutDown)
        return;

      //If user close the window minimize
      if (e.CloseReason == CloseReason.UserClosing) {
        e.Cancel = true;
        this.Hide();
      }
    }

    public void GetDevices()
    {
      //Check if there is an apikey supplied and create an authenticated webclient
      if (wc == null && apikey == "") {
        apikey = Properties.Settings.Default.APIKey;
        if (apikey == "") {
          MessageBox.Show("Please enter your API key in the settings.");
          return;
        }
        wc = AuthenticatedWebClient();
      }

      //Clean up and set default values
      string result = null;
      myBox.Items.Clear();
      sharedBox.Items.Clear();

      //Set webclient header to accept json
      wc.Headers[HttpRequestHeader.Accept] = "application/json";
      try {
        try {
          //Get the devices
          result = wc.DownloadString("https://api.pushbullet.com/api/devices");
        } catch (Exception ex) {
          //Oh no something went wrong, but what?
          result = ex.ToString();
        }
        if (result != null) {
          //Let's parse the json so we can get the device information
          JObject json = (JObject)JsonConvert.DeserializeObject(result);
          csrf = (string)json["csrf"];
          devices = (JArray)json["devices"];
          shared_devices = (JArray)json["shared_devices"];
          foreach (JObject o in devices) {
            if (o["extras"]["nickname"] != null)
              myBox.Items.Add(o["extras"]["nickname"]);
            else
              myBox.Items.Add(o["extras"]["model"]);
          }
          if (shared_devices != null) {
            foreach (JObject o in shared_devices) {
              if (o["extras"]["nickname"] != null)
                sharedBox.Items.Add(o["extras"]["nickname"]);
              else
                sharedBox.Items.Add(o["extras"]["model"]);
            }
          }

        } else {
          MessageBox.Show("We failed and the site returned 404");
        }
        //Set selected device to first and display popup that the login was successfull
        myBox.SelectedIndex = 0;
        notifyIcon1.ShowBalloonTip(1000, "Authenticate", "The authentication was successful!", ToolTipIcon.Info);
        loginBtn.Visible = false;
        pushBtn.Enabled = true;
      } catch (Exception ex) {
        //Oops, something went wrong!
        MessageBox.Show(ex.ToString());
        MessageBox.Show(result);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      GetDevices();
    }

    private void PushNotification(string type, string title, string message)
    {
      try {
        //Set the headers to accept json and send form data
        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
        wc.Headers[HttpRequestHeader.Accept] = "application/json";

        int deviceId;
        //Check which device to send to
        if (myBox.SelectedIndex < 0) {
          deviceId = (int)shared_devices[sharedBox.SelectedIndex]["id"];
        } else {
          deviceId = (int)devices[myBox.SelectedIndex]["id"];
        }

        //First parameters to send
        string parameters = String.Format("device_id={0}&type={1}", deviceId, type);

        //Send different parameters depending on type to push
        //https://api.pushbullet.com/api
        if (type == "note") {
          parameters += String.Format("&title={0}&body={1}", title, message);
        } else if (type == "link") {
          parameters += String.Format("&title={0}&url={1}", title, message);
        } else if (type == "address") {
          parameters += String.Format("&name={0}&address={1}", title, message);
        } else if (type == "list") {
          parameters += String.Format("&title={0}", title);
          if (message == "") {
            foreach (TextBox tb in textBoxes) {
              parameters += String.Format("&items={0}", tb.Text);
            }
          } else {
            string[] items = message.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in items) {
              parameters += String.Format("&items={0}", item);
            }
          }
        }

        //Send the parameters and get the result
        string result = wc.UploadString(HOST + "/api/pushes", parameters);
        notifyIcon1.ShowBalloonTip(1000, "Pushed", "Successfully pushed " + type + " to phone", ToolTipIcon.Info);
        if (type == "list") {
          CleanList();
        }
      } catch (Exception ex) {
        //Oops, sorry man
        MessageBox.Show(ex.ToString());
      }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      //Just check which tab we're using to decide what type to push
      if (tabControl1.SelectedTab.Text == "Link") {
        PushNotification("link", linkTitle.Text, linkUrl.Text);
        linkTitle.Text = "";
        linkUrl.Text = "";
      } else if (tabControl1.SelectedTab.Text == "Note") {
        PushNotification("note", noteTitle.Text, noteTxt.Text);
        noteTitle.Text = "";
        noteTxt.Text = "";
      } else if (tabControl1.SelectedTab.Text == "Address") {
        PushNotification("address", addressTitle.Text, addressTxt.Text);
        addressTitle.Text = "";
        addressTxt.Text = "";
      } else if (tabControl1.SelectedTab.Text == "List") {
        PushNotification("list", listTitle.Text, "");
      }
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
      //Check what can be found on the clipboard
      bool bIsText = Clipboard.ContainsText() && csrf != "";
      bool bIsLink = bIsText && Regex.Match(Clipboard.GetText(), "^(http|https):").Success;

      //Change enabled depending on type on clipboard(link or text)
      linkToolStripMenuItem.Enabled = bIsLink;
      noteToolStripMenuItem.Enabled = bIsText && !bIsLink;
      addressToolStripMenuItem.Enabled = bIsText && !bIsLink;
      listToolStripMenuItem.Enabled = bIsText && !bIsLink;
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      //Show me the window again!
      this.Show();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //Exit for real!
      Application.Exit();
    }

    private void linkToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PushNotification("link", "Link", Clipboard.GetText());
    }

    private void noteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PushNotification("note", "Note", Clipboard.GetText());
    }

    private void addressToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PushNotification("address", "Address", Clipboard.GetText());
    }

    private void listToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PushNotification("list", "List", Clipboard.GetText());
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void loginToolStripMenuItem_Click(object sender, EventArgs e)
    {
      loginBtn.PerformClick();
    }

    private void settingsBtn_Click(object sender, EventArgs e)
    {
      //Show settings form
      new SettingsFrm().ShowDialog();
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      if (hideMe) {
        this.Hide();
        hideMe = false;
      }
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      //We only want to have one device selected
      int l = sharedBox.SelectedIndex;
      myBox.ClearSelected();
      sharedBox.SelectedIndex = l;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      //We only want to have one device selected
      int l = myBox.SelectedIndex;
      sharedBox.ClearSelected();
      myBox.SelectedIndex = l;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Add the first list item
      Label label = new Label();
      label.Location = new Point(listLabel.Location.X, 35 + (23 * textBoxes.Count) + tabPage4.AutoScrollPosition.Y);
      label.Text = "Note item:";
      label.Size = new Size(55, 13);
      TextBox textBox = new TextBox();
      textBox.Size = listTitle.Size;
      textBox.Location = new Point(listTitle.Location.X, 35 + (23 * textBoxes.Count) + tabPage4.AutoScrollPosition.Y);

      addItemBtn.Location = new Point(addItemBtn.Location.X, addItemBtn.Location.Y + 23);
      removeBtn.Location = new Point(removeBtn.Location.X, removeBtn.Location.Y + 23);

      textBoxes.Add(textBox);
      listLabels.Add(label);

      tabPage4.Controls.Add(label);
      tabPage4.Controls.Add(textBox);
    }

    private void removeBtn_Click(object sender, EventArgs e)
    {
      if (textBoxes.Count != 1) {
        //Textboxes
        tabPage4.Controls.Remove(textBoxes[textBoxes.Count - 1]);
        textBoxes.RemoveAt(textBoxes.Count - 1);

        //Labels
        tabPage4.Controls.Remove(listLabels[listLabels.Count - 1]);
        listLabels.RemoveAt(listLabels.Count - 1);

        addItemBtn.Location = new Point(addItemBtn.Location.X, addItemBtn.Location.Y - 23);
        removeBtn.Location = new Point(removeBtn.Location.X, removeBtn.Location.Y - 23);
      }
    }

    public void CleanList()
    {
      for (int i = textBoxes.Count - 1; i > 0; i--) {
        //Textboxes
        tabPage4.Controls.Remove(textBoxes[i]);
        textBoxes.RemoveAt(i);

        //Labels
        tabPage4.Controls.Remove(listLabels[i]);
        listLabels.RemoveAt(i);

        addItemBtn.Location = new Point(addItemBtn.Location.X, addItemBtn.Location.Y - 23);
        removeBtn.Location = new Point(removeBtn.Location.X, removeBtn.Location.Y - 23);
      }
      listTitle.Text = "";
      textBoxes[0].Text = "";
    }

    public void CheckUpdate()
    {
      try {
        WebClient wc = new WebClient();
        string latestVersion = wc.DownloadString("http://dan-l.net/programs/pushbulletversion.txt");
        if (version != latestVersion) {
          notifyIcon1.ShowBalloonTip(1000, "Update", "There's an update available at dan-l.net! "+latestVersion, ToolTipIcon.Info);
        }
      } catch { }
    }

    public void QuickPush(string type, string title, string message)
    {
      GetDevices();
      PushNotification(type, title, message);
      Application.Exit();
    }

    private void okBtn(object sender, EventArgs e)
    {
      Hide();
    }

    void AddDevice(ContextMenuStrip cms, JToken deviceToken, bool shared, int index)
    {
      ToolStripMenuItem tsi = null;
      if ((string)deviceToken["extras"]["nickname"] == null)
        tsi = (ToolStripMenuItem)cms.Items.Add((string)deviceToken["extras"]["model"]);
      else
        tsi = (ToolStripMenuItem)cms.Items.Add((string)deviceToken["extras"]["nickname"]);

      tsi.ImageIndex = (shared ? 1 : 0);

      // clone the menu
      for (int i = 0; i < menuActions.Items.Count; i++) {
        ToolStripItem tsiCopyFrom = menuActions.Items[i];

        ToolStripItem tsiClone = tsi.DropDownItems.Add(tsiCopyFrom.Text);
        tsiClone.Image = tsiCopyFrom.Image;
        tsiClone.Click += new EventHandler((object sender, EventArgs e) => {
          if (!shared) {
            myBox.SelectedIndex = index;
            sharedBox.ClearSelected();
          } else {
            myBox.ClearSelected();
            sharedBox.SelectedIndex = index;
          }
          tsiCopyFrom.PerformClick();
        });
        tsi.DropDownItems.Add(tsiClone);
      }
    }

    private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right) {
        ContextMenuStrip cms = new ContextMenuStrip();
        cms.ImageList = imgListIcons;

        if (csrf == "") {
          ToolStripItem tsi = cms.Items.Add("Authenticate");
          tsi.Image = imgListIcons.Images[2];
          tsi.Click += new EventHandler(authenticateTsi_Click);
        } else {
          for (int i = 0; i < devices.Count; i++) {
            AddDevice(cms, devices[i], false, i);
          }
          if (shared_devices != null) {
            for (int i = 0; i < shared_devices.Count; i++) {
              AddDevice(cms, shared_devices[i], true, i);
            }
          }
        }

        cms.Items.Add(new ToolStripSeparator());

        ToolStripItem tsiExit = cms.Items.Add("Exit");
        tsiExit.Click += new EventHandler(exitTsi_Click);

        notifyIcon1.ContextMenuStrip = cms;
      }
    }

    void exitTsi_Click(object sender, EventArgs e)
    {
      // lol name
      button3.PerformClick();
    }

    void authenticateTsi_Click(object sender, EventArgs e)
    {
      loginBtn.PerformClick();
    }

    private void button1_Click_2(object sender, EventArgs e)
    {
      Hide();
    }

  }
}
