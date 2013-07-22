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
      this.menuActions = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.removeBtn = new System.Windows.Forms.Button();
      this.addItemBtn = new System.Windows.Forms.Button();
      this.listTitle = new System.Windows.Forms.TextBox();
      this.listLabel = new System.Windows.Forms.Label();
      this.imgListIcons = new System.Windows.Forms.ImageList(this.components);
      this.button1 = new System.Windows.Forms.Button();
      this.menuActions.SuspendLayout();
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
      this.pushBtn.Size = new System.Drawing.Size(204, 23);
      this.pushBtn.TabIndex = 4;
      this.pushBtn.Text = "Push";
      this.pushBtn.UseVisualStyleBackColor = true;
      this.pushBtn.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "Pushbullet";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
      this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
      // 
      // menuActions
      // 
      this.menuActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.addressToolStripMenuItem,
            this.listToolStripMenuItem});
      this.menuActions.Name = "contextMenuStrip1";
      this.menuActions.Size = new System.Drawing.Size(117, 92);
      this.menuActions.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // linkToolStripMenuItem
      // 
      this.linkToolStripMenuItem.Image = global::PushBullet.Properties.Resources.link1;
      this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
      this.linkToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
      this.linkToolStripMenuItem.Text = "Link";
      this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
      // 
      // noteToolStripMenuItem
      // 
      this.noteToolStripMenuItem.Image = global::PushBullet.Properties.Resources.note;
      this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
      this.noteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
      this.noteToolStripMenuItem.Text = "Note";
      this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
      // 
      // addressToolStripMenuItem
      // 
      this.addressToolStripMenuItem.Image = global::PushBullet.Properties.Resources.tag;
      this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
      this.addressToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
      this.addressToolStripMenuItem.Text = "Address";
      this.addressToolStripMenuItem.Click += new System.EventHandler(this.addressToolStripMenuItem_Click);
      // 
      // listToolStripMenuItem
      // 
      this.listToolStripMenuItem.Image = global::PushBullet.Properties.Resources.document;
      this.listToolStripMenuItem.Name = "listToolStripMenuItem";
      this.listToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
      this.listToolStripMenuItem.Text = "List";
      this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
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
      this.button3.Location = new System.Drawing.Point(315, 169);
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
      this.settingsBtn.Location = new System.Drawing.Point(257, 3);
      this.settingsBtn.Name = "settingsBtn";
      this.settingsBtn.Size = new System.Drawing.Size(137, 23);
      this.settingsBtn.TabIndex = 14;
      this.settingsBtn.Text = "Settings";
      this.settingsBtn.UseVisualStyleBackColor = true;
      this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
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
      this.tabControl1.Size = new System.Drawing.Size(287, 131);
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
      this.tabPage1.Size = new System.Drawing.Size(279, 105);
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
      this.tabPage2.Size = new System.Drawing.Size(279, 105);
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
      this.tabPage3.Size = new System.Drawing.Size(279, 105);
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
      this.tabPage4.Controls.Add(this.removeBtn);
      this.tabPage4.Controls.Add(this.addItemBtn);
      this.tabPage4.Controls.Add(this.listTitle);
      this.tabPage4.Controls.Add(this.listLabel);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(279, 105);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "List";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // removeBtn
      // 
      this.removeBtn.Location = new System.Drawing.Point(185, 61);
      this.removeBtn.Name = "removeBtn";
      this.removeBtn.Size = new System.Drawing.Size(75, 23);
      this.removeBtn.TabIndex = 23;
      this.removeBtn.Text = "Remove item";
      this.removeBtn.UseVisualStyleBackColor = true;
      this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
      // 
      // addItemBtn
      // 
      this.addItemBtn.Location = new System.Drawing.Point(66, 61);
      this.addItemBtn.Name = "addItemBtn";
      this.addItemBtn.Size = new System.Drawing.Size(75, 23);
      this.addItemBtn.TabIndex = 22;
      this.addItemBtn.Text = "Add item";
      this.addItemBtn.UseVisualStyleBackColor = true;
      this.addItemBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // listTitle
      // 
      this.listTitle.Location = new System.Drawing.Point(66, 12);
      this.listTitle.Name = "listTitle";
      this.listTitle.Size = new System.Drawing.Size(194, 20);
      this.listTitle.TabIndex = 14;
      // 
      // listLabel
      // 
      this.listLabel.AutoSize = true;
      this.listLabel.Location = new System.Drawing.Point(7, 15);
      this.listLabel.Name = "listLabel";
      this.listLabel.Size = new System.Drawing.Size(30, 13);
      this.listLabel.TabIndex = 17;
      this.listLabel.Text = "Title:";
      // 
      // imgListIcons
      // 
      this.imgListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIcons.ImageStream")));
      this.imgListIcons.TransparentColor = System.Drawing.Color.Transparent;
      this.imgListIcons.Images.SetKeyName(0, "phone.png");
      this.imgListIcons.Images.SetKeyName(1, "phone_share.png");
      this.imgListIcons.Images.SetKeyName(2, "lock.png");
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(11, 169);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(81, 23);
      this.button1.TabIndex = 16;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_2);
      // 
      // NewAPI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(406, 199);
      this.Controls.Add(this.button1);
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
      this.menuActions.ResumeLayout(false);
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
    private System.Windows.Forms.ContextMenuStrip menuActions;
    private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
    private System.Windows.Forms.ListBox myBox;
    private System.Windows.Forms.TextBox noteTitle;
    private System.Windows.Forms.TextBox noteTxt;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button3;
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
    private System.Windows.Forms.Button addItemBtn;
    private System.Windows.Forms.TextBox listTitle;
    private System.Windows.Forms.Label listLabel;
    private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
    private System.Windows.Forms.Button removeBtn;
    private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    private System.Windows.Forms.ImageList imgListIcons;
    private System.Windows.Forms.Button button1;
  }
}

