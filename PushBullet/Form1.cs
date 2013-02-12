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

namespace PushBullet
{
  public partial class Form1 : Form
  {
    #region Members
    public static CookieContainer cookieContainer = new CookieContainer();
    private string HOST = "https://www.pushbullet.com";
    private string csrf = "";
    private JArray devices;
    private bool hideMe;
    #endregion

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Default values! 
      label1.Text = "";
      comboBox1.SelectedIndex = 0;

      //Do we want to open normally or in tray?
      string[] args = Environment.GetCommandLineArgs();
      foreach (string arg in args) {
        if (arg == "/tray") {
          hideMe = true;
        }
      }
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
      try {
        listBox1.Items.Clear();
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(HOST + "/devices");

        req.CookieContainer = cookieContainer;
        req.Method = "GET";
        req.Accept = "application/json";

        HttpWebResponse res = null;
        try {
          res = (HttpWebResponse)req.GetResponse();
        }
        catch (WebException ex) {
          res = (HttpWebResponse)ex.Response;
        }
        if (res.StatusCode == HttpStatusCode.OK) {
          StreamReader reader = new StreamReader(res.GetResponseStream());
          JObject json = (JObject)JsonConvert.DeserializeObject(reader.ReadToEnd());
          csrf = (string)json["csrf"];
          devices = (JArray)json["devices"];
          foreach (JObject o in devices) {
            listBox1.Items.Add(o["extras"]["model"]);
          }

        }
        else if (res.StatusCode == HttpStatusCode.NotFound) {
          textBox1.Text = "We failed and the site returned 404";
        }
        label1.Text = "Devices:";
        listBox1.SelectedIndex = 0;
      }
      catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //Let's open the authentication window!
      new Form2(this).ShowDialog();
    }

    private void PushNotification(string type, string title, string message)
    {
      try {
        HttpWebRequest reqs = (HttpWebRequest)WebRequest.Create(HOST + "/push/" + type);
        reqs.CookieContainer = cookieContainer;
        reqs.Method = "POST";
        reqs.ContentType = "application/json";
        reqs.Accept = "application/json";

        Data nd = null;

        if (type == "note") {
          nd = new NoteData();
          nd.type = type;
          nd._csrf = csrf;
          nd.device_id = (int)devices[listBox1.SelectedIndex]["id"];
          nd.title = title;
          (nd as NoteData).body = message;
        }
        else if (type == "link") {
          nd = new LinkData();
          nd.type = type;
          nd._csrf = csrf;
          nd.device_id = (int)devices[listBox1.SelectedIndex]["id"];
          nd.title = title;
          (nd as LinkData).url = message;
        }

        string json = JsonConvert.SerializeObject(nd);
        byte[] utf = System.Text.Encoding.UTF8.GetBytes(json);

        reqs.ContentLength = utf.Length;

        using (Stream streamWriter = reqs.GetRequestStream()) {
          streamWriter.Write(utf, 0, utf.Length);
          streamWriter.Close();

          HttpWebResponse httpResponse = (HttpWebResponse)reqs.GetResponse();
          using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream())) {
            string result = streamReader.ReadToEnd();
          }
        }
      }
      catch (Exception ex) {
        MessageBox.Show(ex.ToString());
      }
    }

    #region We got cookies!
    [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
    static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref uint pcchCookieData, int dwFlags, IntPtr lpReserved);
    const int INTERNET_COOKIE_HTTPONLY = 0x00002000;

    public static string GetGlobalCookies(string uri)
    {
      uint datasize = 1024;
      StringBuilder cookieData = new StringBuilder((int)datasize);
      if (InternetGetCookieEx(uri, null, cookieData, ref datasize, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero)
          && cookieData.Length > 0) {
        return cookieData.ToString().Replace(';', ',');
      }
      else {
        return null;
      }
    }
    #endregion

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
      if (Clipboard.ContainsText() && csrf != "") {
        if (Clipboard.GetText().StartsWith("http://") || Clipboard.GetText().StartsWith("https://")) {
          linkToolStripMenuItem.Enabled = true;
          noteToolStripMenuItem.Enabled = false;
        }
        else {
          linkToolStripMenuItem.Enabled = false;
          noteToolStripMenuItem.Enabled = true;
        }
        loginToolStripMenuItem.Visible = false;
      }
      else {
        linkToolStripMenuItem.Enabled = false;
        noteToolStripMenuItem.Enabled = false;
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
      button2.PerformClick();
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      if (hideMe) {
        Hide();
        hideMe = false;
      }
    }

  }
}
