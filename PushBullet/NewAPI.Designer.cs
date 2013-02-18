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
      this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.myBox = new System.Windows.Forms.ListBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.sharedBox = new System.Windows.Forms.ListBox();
      this.label5 = new System.Windows.Forms.Label();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // loginBtn
      // 
      this.loginBtn.Location = new System.Drawing.Point(107, 3);
      this.loginBtn.Name = "loginBtn";
      this.loginBtn.Size = new System.Drawing.Size(275, 23);
      this.loginBtn.TabIndex = 0;
      this.loginBtn.Text = "Login";
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
      this.pushBtn.Location = new System.Drawing.Point(105, 143);
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
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(105, 92);
      this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // linkToolStripMenuItem
      // 
      this.linkToolStripMenuItem.Image = global::PushBullet.Properties.Resources.link1;
      this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
      this.linkToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
      this.linkToolStripMenuItem.Text = "Link";
      this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
      // 
      // noteToolStripMenuItem
      // 
      this.noteToolStripMenuItem.Image = global::PushBullet.Properties.Resources.note;
      this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
      this.noteToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
      this.noteToolStripMenuItem.Text = "Note";
      this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
      // 
      // loginToolStripMenuItem
      // 
      this.loginToolStripMenuItem.Image = global::PushBullet.Properties.Resources._lock;
      this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
      this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
      this.loginToolStripMenuItem.Text = "Login";
      this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
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
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(163, 56);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(218, 20);
      this.textBox2.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(163, 79);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(218, 55);
      this.textBox1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(104, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Message:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(104, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(30, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Title:";
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "link",
            "note"});
      this.comboBox1.Location = new System.Drawing.Point(163, 29);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.Tag = "";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(104, 32);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Type:";
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(306, 143);
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(393, 175);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.sharedBox);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.pushBtn);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.loginBtn);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.myBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pushbullet Desktop";
      this.Activated += new System.EventHandler(this.Form1_Activated);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.contextMenuStrip1.ResumeLayout(false);
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
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    private System.Windows.Forms.ListBox sharedBox;
    public System.Windows.Forms.Label label5;
    public System.Windows.Forms.Button pushBtn;
  }
}

