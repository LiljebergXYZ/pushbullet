using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PushBullet
{
    public partial class SettingsFrm : Form
    {

        RegistryKey autostartRegKey;

        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            apiTxt.Text = Properties.Settings.Default.APIKey;
            autostartRegKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            autoRun.Checked = autostartRegKey.GetValue("PushBullet") != null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (autoRun.Checked)
                autostartRegKey.SetValue("PushBullet", Application.ExecutablePath + " /tray");
              else
                autostartRegKey.DeleteValue("PushBulleYt", false);

            Properties.Settings.Default.APIKey = apiTxt.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
