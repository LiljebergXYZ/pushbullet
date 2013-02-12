using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PushBullet
{
  public partial class Form2 : Form
  {

    Form1 frm;

    public Form2(Form1 frm1)
    {
      frm = frm1;
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      
    }

    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      Form1.cookieContainer.SetCookies(webBrowser1.Url, Form1.GetGlobalCookies(webBrowser1.Document.Url.AbsoluteUri));
      if (webBrowser1.Document.Body.InnerHtml.Contains("My Devices")) {
        this.Hide();
        frm.label1.Text = "Getting devices...";
        frm.button2.Visible = false;
        frm.GetDevices();
      }
    }
  }
}
