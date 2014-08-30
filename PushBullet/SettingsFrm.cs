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
        NewAPI mainForm;

        public SettingsFrm(NewAPI frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            apiTxt.Text = Properties.Settings.Default.APIKey;
            autostartRegKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            autoRun.Checked = autostartRegKey.GetValue("PushBullet") != null;
            autoAuthChk.Checked = Properties.Settings.Default.AutoAuth;
            checkBox1.Checked = Properties.Settings.Default.UseProxy;
            proxyIp.Text = Properties.Settings.Default.ProxyIP;
            proxyPort.Text = Properties.Settings.Default.ProxyPort.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (autoRun.Checked)
                autostartRegKey.SetValue("PushBullet", Application.ExecutablePath + " /tray");
              else
                autostartRegKey.DeleteValue("PushBullet", false);

            Properties.Settings.Default.UseProxy = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.ProxyIP = proxyIp.Text;
                Properties.Settings.Default.ProxyPort = Convert.ToInt16(proxyPort.Text);
            }

            Properties.Settings.Default.AutoAuth = autoAuthChk.Checked;
            Properties.Settings.Default.APIKey = apiTxt.Text;
            Properties.Settings.Default.Save();
            mainForm.wc = mainForm.AuthenticatedWebClient();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                proxyIp.Enabled = true;
                proxyPort.Enabled = true;
            }
            else
            {
                proxyIp.Enabled = false;
                proxyPort.Enabled = false;
            }
        }

        private void proxyPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void proxyIp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.Split('.').Count() > 3)
            {
                e.Handled = true;
            }
        }
    }
}
