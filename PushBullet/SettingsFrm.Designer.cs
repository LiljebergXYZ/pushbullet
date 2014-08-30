namespace PushBullet
{
    partial class SettingsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFrm));
            this.apiTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.autoRun = new System.Windows.Forms.CheckBox();
            this.autoAuthChk = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proxyIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proxyPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // apiTxt
            // 
            this.apiTxt.Location = new System.Drawing.Point(79, 12);
            this.apiTxt.Name = "apiTxt";
            this.apiTxt.Size = new System.Drawing.Size(203, 20);
            this.apiTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autoRun
            // 
            this.autoRun.AutoSize = true;
            this.autoRun.Location = new System.Drawing.Point(79, 111);
            this.autoRun.Name = "autoRun";
            this.autoRun.Size = new System.Drawing.Size(145, 17);
            this.autoRun.TabIndex = 3;
            this.autoRun.Text = "Start on Windows startup";
            this.autoRun.UseVisualStyleBackColor = true;
            // 
            // autoAuthChk
            // 
            this.autoAuthChk.AutoSize = true;
            this.autoAuthChk.Location = new System.Drawing.Point(79, 88);
            this.autoAuthChk.Name = "autoAuthChk";
            this.autoAuthChk.Size = new System.Drawing.Size(133, 17);
            this.autoAuthChk.TabIndex = 4;
            this.autoAuthChk.Text = "Authenticate at startup";
            this.autoAuthChk.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(79, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Use Proxy";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP Address:";
            // 
            // proxyIp
            // 
            this.proxyIp.Enabled = false;
            this.proxyIp.Location = new System.Drawing.Point(79, 61);
            this.proxyIp.Name = "proxyIp";
            this.proxyIp.Size = new System.Drawing.Size(125, 20);
            this.proxyIp.TabIndex = 6;
            this.proxyIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proxyIp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port:";
            // 
            // proxyPort
            // 
            this.proxyPort.Enabled = false;
            this.proxyPort.Location = new System.Drawing.Point(248, 61);
            this.proxyPort.MaxLength = 5;
            this.proxyPort.Name = "proxyPort";
            this.proxyPort.Size = new System.Drawing.Size(34, 20);
            this.proxyPort.TabIndex = 9;
            this.proxyPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proxyPort_KeyPress);
            // 
            // SettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 172);
            this.Controls.Add(this.proxyPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proxyIp);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.autoAuthChk);
            this.Controls.Add(this.autoRun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apiTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox autoRun;
        private System.Windows.Forms.CheckBox autoAuthChk;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proxyIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proxyPort;
    }
}