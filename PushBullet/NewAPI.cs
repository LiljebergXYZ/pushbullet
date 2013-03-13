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
    private string HOST = "https://www.pushbullet.com";
    private string csrf = "";
    private JArray devices;
    private JArray shared_devices;
    private bool hideMe;
    private string apikey = "";
    private string version = "1.1";
    private WebClient wc;
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

      //Create an authenticated webclient if apikey already supplied
      apikey = Properties.Settings.Default.APIKey;
      if (apikey != "")
      {
          wc = AuthenticatedWebClient();
      }
    }

    public WebClient AuthenticatedWebClient()
    {
      WebClient wc = new WebClient();
      wc.Proxy = null;
      string authEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(apikey+":"));
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
        if (wc == null && apikey == "")
        {
            apikey = Properties.Settings.Default.APIKey;
            if (apikey == "")
            {
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
          result = wc.DownloadString("https://www.pushbullet.com/api/devices");
        }
        catch (Exception ex) {
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
            myBox.Items.Add(o["extras"]["model"]);
          }
          if (shared_devices != null)
          {
              foreach (JObject o in shared_devices)
              {
                  sharedBox.Items.Add(o["ownerName"] + " - " + o["extras"]["model"]);
              }
          }

        }
        else {
          MessageBox.Show("We failed and the site returned 404");
        }
        //Set selected device to first and display popup that the login was successfull
        myBox.SelectedIndex = 0;
        notifyIcon1.ShowBalloonTip(1000, "Authenticate", "The authentication was successful!", ToolTipIcon.Info);
        loginBtn.Visible = false;
        pushBtn.Enabled = true;
      }
      catch (Exception ex) {
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
        if(myBox.SelectedIndex < 0){
          deviceId = (int)shared_devices[sharedBox.SelectedIndex]["id"];
        }else{
          deviceId = (int)devices[myBox.SelectedIndex]["id"];
        }

        //First parameters to send
        string parameters = String.Format("device_id={0}&type={1}", deviceId, type);

        //Send different parameters depending on type to push
        //https://www.pushbullet.com/api
        if (type == "note") {
          parameters += String.Format("&title={0}&body={1}", title, message);
        }
        else if (type == "link") {
          parameters += String.Format("&title={0}&url={1}", title, message);
        }
        else if (type == "address")
        {
            parameters += String.Format("&name={0}&address={1}", title, message);
        }

        //Send the parameters and get the result
        string result = wc.UploadString(HOST + "/api/pushes", parameters);
        notifyIcon1.ShowBalloonTip(1000, "Pushed", "Successfully pushed " + type + " to phone", ToolTipIcon.Info);
      }
      catch (Exception ex) {
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
      }
      else if (tabControl1.SelectedTab.Text == "Note")
      {
        PushNotification("note", noteTitle.Text, noteTxt.Text);
        noteTitle.Text = "";
        noteTxt.Text = "";
      }
      else if (tabControl1.SelectedTab.Text == "Address")
      {
          PushNotification("address", addressTitle.Text, addressTxt.Text);
          addressTitle.Text = "";
          addressTxt.Text = "";
      }
      else if (tabControl1.SelectedTab.Text == "List")
      {
          //Todo
          MessageBox.Show("List not supported at the moment");
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
      if (csrf != "") {
        loginToolStripMenuItem.Visible = false;
      }
      else {
        loginToolStripMenuItem.Visible = true;
      }
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

    private void button3_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void loginToolStripMenuItem_Click(object sender, EventArgs e)
    {
      loginBtn.PerformClick();
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
        //Settings button
        new SettingsFrm().ShowDialog();
    }

  }
}
