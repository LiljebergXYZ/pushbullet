namespace PushBullet
{
  partial class NewAPI
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
      if (disposing && (components != null)) {
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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAPI));
        this.loginBtn = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.pushBtn = new System.Windows.Forms.Button();
        this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
        this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.myBox = new System.Windows.Forms.ListBox();
        this.noteTitle = new System.Windows.Forms.TextBox();
        this.noteTxt = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.button3 = new System.Windows.Forms.Button();
        this.sharedBox = new System.Windows.Forms.ListBox();
        this.label5 = new System.Windows.Forms.Label();
        this.settingsBtn = new System.Windows.Forms.Button();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.linkUrl = new System.Windows.Forms.TextBox();
        this.linkTitle = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.addressTxt = new System.Windows.Forms.TextBox();
        this.addressTitle = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.tabPage4 = new System.Windows.Forms.TabPage();
        this.button1 = new System.Windows.Forms.Button();
        this.textBox4 = new System.Windows.Forms.TextBox();
        this.label12 = new System.Windows.Forms.Label();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.label11 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.label9 = new System.Windows.Forms.Label();
        this.label10 = new System.Windows.Forms.Label();
        this.contextMenuStrip1.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.tabPage3.SuspendLayout();
        this.tabPage4.SuspendLayout();
        this.SuspendLayout();
        // 
        // loginBtn
        // 
        this.loginBtn.Location = new System.Drawing.Point(107, 3);
        this.loginBtn.Name = "loginBtn";
        this.loginBtn.Size = new System.Drawing.Size(137, 23);
        this.loginBtn.TabIndex = 0;
        this.loginBtn.Text = "Authenticate";
        this.loginBtn.UseVisualStyleBackColor = true;
        this.loginBtn.Click += new System.EventHandler(this.button2_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(8, 17);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(64, 13);
        this.label1.TabIndex = 4;
        this.label1.Text = "My devices:";
        // 
        // pushBtn
        // 
        this.pushBtn.Enabled = false;
        this.pushBtn.Location = new System.Drawing.Point(105, 169);
        this.pushBtn.Name = "pushBtn";
        this.pushBtn.Size = new System.Drawing.Size(195, 23);
        this.pushBtn.TabIndex = 4;
        this.pushBtn.Text = "Push";
        this.pushBtn.UseVisualStyleBackColor = true;
        this.pushBtn.Click += new System.EventHandler(this.button1_Click_1);
        // 
        // notifyIcon1
        // 
        this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
        this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
        this.notifyIcon1.Text = "Pushbullet";
        this.notifyIcon1.Visible = true;
        this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
        // 
        // contextMenuStrip1
        // 
        this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
        this.contextMenuStrip1.Name = "contextMenuStrip1";
        this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
        this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
        // 
        // linkToolStripMenuItem
        // 
        this.linkToolStripMenuItem.Image = global::PushBullet.Properties.Resources.link1;
        this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
        this.linkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.linkToolStripMenuItem.Text = "Link";
        this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
        // 
        // noteToolStripMenuItem
        // 
        this.noteToolStripMenuItem.Image = global::PushBullet.Properties.Resources.note;
        this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
        this.noteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.noteToolStripMenuItem.Text = "Note";
        this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
        // 
        // addressToolStripMenuItem
        // 
        this.addressToolStripMenuItem.Image = global::PushBullet.Properties.Resources.tag;
        this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
        this.addressToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.addressToolStripMenuItem.Text = "Address";
        this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
        // 
        // loginToolStripMenuItem
        // 
        this.loginToolStripMenuItem.Image = global::PushBullet.Properties.Resources.lock1;
        this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
        this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.loginToolStripMenuItem.Text = "Authenticate";
        this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
        // 
        // exitToolStripMenuItem
        // 
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.exitToolStripMenuItem.Text = "Exit";
        this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        // 
        // myBox
        // 
        this.myBox.FormattingEnabled = true;
        this.myBox.Location = new System.Drawing.Point(11, 33);
        this.myBox.Name = "myBox";
        this.myBox.Size = new System.Drawing.Size(81, 56);
        this.myBox.TabIndex = 6;
        this.myBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
        // 
        // noteTitle
        // 
        this.noteTitle.Location = new System.Drawing.Point(66, 12);
        this.noteTitle.Name = "noteTitle";
        this.noteTitle.Size = new System.Drawing.Size(194, 20);
        this.noteTitle.TabIndex = 2;
        // 
        // noteTxt
        // 
        this.noteTxt.Location = new System.Drawing.Point(66, 35);
        this.noteTxt.Multiline = true;
        this.noteTxt.Name = "noteTxt";
        this.noteTxt.Size = new System.Drawing.Size(194, 55);
        this.noteTxt.TabIndex = 3;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(7, 37);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(53, 13);
        this.label2.TabIndex = 8;
        this.label2.Text = "Message:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(7, 15);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(30, 13);
        this.label3.TabIndex = 9;
        this.label3.Text = "Title:";
        // 
        // button3
        // 
        this.button3.Location = new System.Drawing.Point(306, 169);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(75, 23);
        this.button3.TabIndex = 5;
        this.button3.Text = "Quit";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // sharedBox
        // 
        this.sharedBox.FormattingEnabled = true;
        this.sharedBox.Location = new System.Drawing.Point(11, 107);
        this.sharedBox.Name = "sharedBox";
        this.sharedBox.Size = new System.Drawing.Size(81, 56);
        this.sharedBox.TabIndex = 12;
        this.sharedBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(8, 92);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(84, 13);
        this.label5.TabIndex = 13;
        this.label5.Text = "Shared devices:";
        // 
        // settingsBtn
        // 
        this.settingsBtn.Location = new System.Drawing.Point(250, 3);
        this.settingsBtn.Name = "settingsBtn";
        this.settingsBtn.Size = new System.Drawing.Size(137, 23);
        this.settingsBtn.TabIndex = 14;
        this.settingsBtn.Text = "Settings";
        this.settingsBtn.UseVisualStyleBackColor = true;
        this.settingsBtn.Click += new System.EventHandler(this.button1_Click);
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Controls.Add(this.tabPage4);
        this.tabControl1.Location = new System.Drawing.Point(107, 32);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(274, 131);
        this.tabControl1.TabIndex = 15;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.noteTxt);
        this.tabPage1.Controls.Add(this.noteTitle);
        this.tabPage1.Controls.Add(this.label2);
        this.tabPage1.Controls.Add(this.label3);
        this.tabPage1.Location = new System.Drawing.Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(266, 105);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Note";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.linkUrl);
        this.tabPage2.Controls.Add(this.linkTitle);
        this.tabPage2.Controls.Add(this.label4);
        this.tabPage2.Controls.Add(this.label6);
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(266, 105);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Link";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // linkUrl
        // 
        this.linkUrl.Location = new System.Drawing.Point(66, 35);
        this.linkUrl.Name = "linkUrl";
        this.linkUrl.Size = new System.Drawing.Size(194, 20);
        this.linkUrl.TabIndex = 11;
        // 
        // linkTitle
        // 
        this.linkTitle.Location = new System.Drawing.Point(66, 12);
        this.linkTitle.Name = "linkTitle";
        this.linkTitle.Size = new System.Drawing.Size(194, 20);
        this.linkTitle.TabIndex = 10;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(7, 38);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(32, 13);
        this.label4.TabIndex = 12;
        this.label4.Text = "URL:";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(7, 15);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(30, 13);
        this.label6.TabIndex = 13;
        this.label6.Text = "Title:";
        // 
        // tabPage3
        // 
        this.tabPage3.Controls.Add(this.addressTxt);
        this.tabPage3.Controls.Add(this.addressTitle);
        this.tabPage3.Controls.Add(this.label7);
        this.tabPage3.Controls.Add(this.label8);
        this.tabPage3.Location = new System.Drawing.Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Size = new System.Drawing.Size(266, 105);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "Address";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // addressTxt
        // 
        this.addressTxt.Location = new System.Drawing.Point(66, 35);
        this.addressTxt.Multiline = true;
        this.addressTxt.Name = "addressTxt";
        this.addressTxt.Size = new System.Drawing.Size(194, 55);
        this.addressTxt.TabIndex = 11;
        // 
        // addressTitle
        // 
        this.addressTitle.Location = new System.Drawing.Point(66, 12);
        this.addressTitle.Name = "addressTitle";
        this.addressTitle.Size = new System.Drawing.Size(194, 20);
        this.addressTitle.TabIndex = 10;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(7, 37);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(48, 13);
        this.label7.TabIndex = 12;
        this.label7.Text = "Address:";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(7, 15);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(38, 13);
        this.label8.TabIndex = 13;
        this.label8.Text = "Name:";
        // 
        // tabPage4
        // 
        this.tabPage4.AutoScroll = true;
        this.tabPage4.Controls.Add(this.button1);
        this.tabPage4.Controls.Add(this.textBox4);
        this.tabPage4.Controls.Add(this.label12);
        this.tabPage4.Controls.Add(this.textBox3);
        this.tabPage4.Controls.Add(this.label11);
        this.tabPage4.Controls.Add(this.textBox1);
        this.tabPage4.Controls.Add(this.textBox2);
        this.tabPage4.Controls.Add(this.label9);
        this.tabPage4.Controls.Add(this.label10);
        this.tabPage4.Location = new System.Drawing.Point(4, 22);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Size = new System.Drawing.Size(266, 105);
        this.tabPage4.TabIndex = 3;
        this.tabPage4.Text = "List";
        this.tabPage4.ToolTipText = "Not available";
        this.tabPage4.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(114, 113);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 22;
        this.button1.Text = "Add item";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // textBox4
        // 
        this.textBox4.Location = new System.Drawing.Point(66, 81);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new System.Drawing.Size(176, 20);
        this.textBox4.TabIndex = 20;
        this.textBox4.Tag = "item1";
        // 
        // label12
        // 
        this.label12.AutoSize = true;
        this.label12.Location = new System.Drawing.Point(7, 84);
        this.label12.Name = "label12";
        this.label12.Size = new System.Drawing.Size(55, 13);
        this.label12.TabIndex = 21;
        this.label12.Text = "Note item:";
        // 
        // textBox3
        // 
        this.textBox3.Location = new System.Drawing.Point(66, 58);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(176, 20);
        this.textBox3.TabIndex = 18;
        this.textBox3.Tag = "item1";
        // 
        // label11
        // 
        this.label11.AutoSize = true;
        this.label11.Location = new System.Drawing.Point(7, 61);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(55, 13);
        this.label11.TabIndex = 19;
        this.label11.Text = "Note item:";
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(66, 35);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(176, 20);
        this.textBox1.TabIndex = 15;
        this.textBox1.Tag = "item1";
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(66, 12);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(176, 20);
        this.textBox2.TabIndex = 14;
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new System.Drawing.Point(7, 38);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(55, 13);
        this.label9.TabIndex = 16;
        this.label9.Text = "Note item:";
        // 
        // label10
        // 
        this.label10.AutoSize = true;
        this.label10.Location = new System.Drawing.Point(7, 15);
        this.label10.Name = "label10";
        this.label10.Size = new System.Drawing.Size(30, 13);
        this.label10.TabIndex = 17;
        this.label10.Text = "Title:";
        // 
        // NewAPI
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(393, 199);
        this.Controls.Add(this.settingsBtn);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.sharedBox);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.pushBtn);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.loginBtn);
        this.Controls.Add(this.myBox);
        this.Controls.Add(this.tabControl1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "NewAPI";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Pushbullet Desktop";
        this.Activated += new System.EventHandler(this.Form1_Activated);
        this.Load += new System.EventHandler(this.Form1_Load);
        this.contextMenuStrip1.ResumeLayout(false);
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.tabPage3.ResumeLayout(false);
        this.tabPage3.PerformLayout();
        this.tabPage4.ResumeLayout(false);
        this.tabPage4.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Button loginBtn;
    public System.Windows.Forms.Label label1;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ListBox myBox;
    private System.Windows.Forms.TextBox noteTitle;
    private System.Windows.Forms.TextBox noteTxt;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    private System.Windows.Forms.ListBox sharedBox;
    public System.Windows.Forms.Label label5;
    public System.Windows.Forms.Button pushBtn;
    public System.Windows.Forms.Button settingsBtn;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox linkUrl;
    private System.Windows.Forms.TextBox linkTitle;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TextBox addressTxt;
    private System.Windows.Forms.TextBox addressTitle;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
  }
}

