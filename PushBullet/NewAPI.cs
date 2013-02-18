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
    private string version = "1.0";
    #endregion

    public NewAPI()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Default values! 
      comboBox1.SelectedIndex = 0;

      //Do we want to open normally or in tray?
      string[] args = Environment.GetCommandLineArgs();
      foreach (string arg in args) {
        if (arg == "/tray") {
          hideMe = true;
        }
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
      string result = null;
      myBox.Items.Clear();
      sharedBox.Items.Clear();

      WebClient wc = AuthenticatedWebClient();

      wc.Headers[HttpRequestHeader.Accept] = "application/json";
      try {
        try {
          result = wc.DownloadString("https://www.pushbullet.com/api/devices");
        }
        catch (Exception ex) {
          result = ex.ToString();
        }
        if (result != null) {
          JObject json = (JObject)JsonConvert.DeserializeObject(result);
          csrf = (string)json["csrf"];
          devices = (JArray)json["devices"];
          shared_devices = (JArray)json["shared_devices"];
          foreach (JObject o in devices) {
            myBox.Items.Add(o["extras"]["model"]);
          }
          foreach (JObject o in shared_devices) {
            sharedBox.Items.Add(o["ownerName"] + " - " + o["extras"]["model"]);
          }

        }
        else {
          MessageBox.Show("We failed and the site returned 404");
        }
        myBox.SelectedIndex = 0;
        notifyIcon1.ShowBalloonTip(1000, "Login", "The login was successful!", ToolTipIcon.Info);
        loginBtn.Visible = false;
      }
      catch (Exception ex) {
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
        WebClient wc = AuthenticatedWebClient();
        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
        wc.Headers[HttpRequestHeader.Accept] = "application/json";

        int deviceId;
        if(myBox.SelectedIndex < 0){
          deviceId = (int)shared_devices[sharedBox.SelectedIndex]["id"];
        }else{
          deviceId = (int)devices[myBox.SelectedIndex]["id"];
        }

        string parameters = String.Format("device_id={0}&type={1}", deviceId, type);

        if (type == "note") {
          parameters += String.Format("&title={0}&body={1}", title, message);
        }
        else if (type == "link") {
          parameters += String.Format("&title={0}&url={1}", title, message);
        }

        string result = wc.UploadString(HOST + "/api/pushes", parameters);
      }
      catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      if (comboBox1.SelectedItem.ToString() == "link") {
        PushNotification("link", textBox2.Text, textBox1.Text);
      }
      else if (comboBox1.SelectedItem.ToString() == "note") {
        PushNotification("note", textBox2.Text, textBox1.Text);
      }
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
      bool bIsText = Clipboard.ContainsText() && csrf != "";
      bool bIsLink = bIsText && Regex.Match(Clipboard.GetText(), "^(http|https):").Success;

      linkToolStripMenuItem.Enabled = bIsLink;
      noteToolStripMenuItem.Enabled = bIsText && !bIsLink;
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
      int l = sharedBox.SelectedIndex;
      myBox.ClearSelected();
      sharedBox.SelectedIndex = l;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      int l = myBox.SelectedIndex;
      sharedBox.ClearSelected();
      myBox.SelectedIndex = l;
    }

  }
}
