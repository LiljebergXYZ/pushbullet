using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PushBullet
{
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            apiTxt.Text = Properties.Settings.Default.APIKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.APIKey = apiTxt.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
