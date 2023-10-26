namespace PAPS
{
    partial class Form1
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
            this.TF2Man = new System.Windows.Forms.PictureBox();
            this.GeneralLog = new System.Windows.Forms.RichTextBox();
            this.Directories = new System.Windows.Forms.Panel();
            this.appdatapathbrowse = new System.Windows.Forms.Button();
            this.exepathbrowse = new System.Windows.Forms.Button();
            this.appdatapath = new System.Windows.Forms.TextBox();
            this.exepath = new System.Windows.Forms.TextBox();
            this.appdatalabel = new System.Windows.Forms.Label();
            this.apppathlabel = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.Fbimode = new System.Windows.Forms.CheckBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ADLshortcut = new System.Windows.Forms.Button();
            this.SaveSlotLabel = new System.Windows.Forms.Label();
            this.SaveSlot = new System.Windows.Forms.TextBox();
            this.DelayNum = new System.Windows.Forms.TextBox();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.consoletoggle = new System.Windows.Forms.CheckBox();
            this.Pause = new System.Windows.Forms.CheckBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Settingstab = new System.Windows.Forms.TabPage();
            this.Loggertab = new System.Windows.Forms.TabPage();
            this.launchapptoggle = new System.Windows.Forms.CheckBox();
            this.Blacklistlabel = new System.Windows.Forms.Label();
            this.ScanpathLabel = new System.Windows.Forms.Label();
            this.blacklist = new System.Windows.Forms.TextBox();
            this.fetchlist = new System.Windows.Forms.ListBox();
            this.ScannerButton = new System.Windows.Forms.Button();
            this.fetchpath = new System.Windows.Forms.TextBox();
            this.Logtab = new System.Windows.Forms.TabPage();
            this.modetoggle = new System.Windows.Forms.Button();
            this.settingstogglelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TF2Man)).BeginInit();
            this.Directories.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Settingstab.SuspendLayout();
            this.Loggertab.SuspendLayout();
            this.Logtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TF2Man
            // 
            this.TF2Man.BackColor = System.Drawing.SystemColors.Control;
            this.TF2Man.Location = new System.Drawing.Point(6, 6);
            this.TF2Man.Name = "TF2Man";
            this.TF2Man.Size = new System.Drawing.Size(97, 95);
            this.TF2Man.TabIndex = 0;
            this.TF2Man.TabStop = false;
            // 
            // GeneralLog
            // 
            this.GeneralLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneralLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralLog.Location = new System.Drawing.Point(3, 3);
            this.GeneralLog.Name = "GeneralLog";
            this.GeneralLog.Size = new System.Drawing.Size(786, 378);
            this.GeneralLog.TabIndex = 1;
            this.GeneralLog.Text = "This is where the log is going to show up once you make a shortcut.\n";
            // 
            // Directories
            // 
            this.Directories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Directories.Controls.Add(this.appdatapathbrowse);
            this.Directories.Controls.Add(this.exepathbrowse);
            this.Directories.Controls.Add(this.appdatapath);
            this.Directories.Controls.Add(this.exepath);
            this.Directories.Controls.Add(this.appdatalabel);
            this.Directories.Controls.Add(this.apppathlabel);
            this.Directories.Location = new System.Drawing.Point(109, 6);
            this.Directories.Name = "Directories";
            this.Directories.Size = new System.Drawing.Size(677, 95);
            this.Directories.TabIndex = 2;
            // 
            // appdatapathbrowse
            // 
            this.appdatapathbrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appdatapathbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appdatapathbrowse.Location = new System.Drawing.Point(587, 43);
            this.appdatapathbrowse.Name = "appdatapathbrowse";
            this.appdatapathbrowse.Size = new System.Drawing.Size(75, 31);
            this.appdatapathbrowse.TabIndex = 3;
            this.appdatapathbrowse.Text = "Browse";
            this.appdatapathbrowse.UseVisualStyleBackColor = true;
            this.appdatapathbrowse.Click += new System.EventHandler(this.appdatapathbrowse_Click);
            // 
            // exepathbrowse
            // 
            this.exepathbrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exepathbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exepathbrowse.Location = new System.Drawing.Point(587, 6);
            this.exepathbrowse.Name = "exepathbrowse";
            this.exepathbrowse.Size = new System.Drawing.Size(75, 31);
            this.exepathbrowse.TabIndex = 3;
            this.exepathbrowse.Text = "Browse";
            this.exepathbrowse.UseVisualStyleBackColor = true;
            this.exepathbrowse.Click += new System.EventHandler(this.exepathbrowse_Click);
            // 
            // appdatapath
            // 
            this.appdatapath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.appdatapath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appdatapath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appdatapath.Location = new System.Drawing.Point(132, 43);
            this.appdatapath.Name = "appdatapath";
            this.appdatapath.Size = new System.Drawing.Size(454, 31);
            this.appdatapath.TabIndex = 4;
            this.appdatapath.TextChanged += new System.EventHandler(this.appdatapath_TextChanged);
            // 
            // exepath
            // 
            this.exepath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exepath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exepath.Location = new System.Drawing.Point(106, 6);
            this.exepath.Name = "exepath";
            this.exepath.Size = new System.Drawing.Size(480, 31);
            this.exepath.TabIndex = 4;
            this.exepath.TextChanged += new System.EventHandler(this.exepath_TextChanged);
            // 
            // appdatalabel
            // 
            this.appdatalabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.appdatalabel.AutoSize = true;
            this.appdatalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appdatalabel.Location = new System.Drawing.Point(4, 47);
            this.appdatalabel.Name = "appdatalabel";
            this.appdatalabel.Size = new System.Drawing.Size(123, 20);
            this.appdatalabel.TabIndex = 3;
            this.appdatalabel.Text = "App Data Path:";
            // 
            // apppathlabel
            // 
            this.apppathlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.apppathlabel.AutoSize = true;
            this.apppathlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apppathlabel.Location = new System.Drawing.Point(4, 16);
            this.apppathlabel.Name = "apppathlabel";
            this.apppathlabel.Size = new System.Drawing.Size(96, 20);
            this.apppathlabel.TabIndex = 3;
            this.apppathlabel.Text = "Executable:";
            // 
            // openfile
            // 
            this.openfile.Filter = "Common Executables|*.EXE|All files|*.*";
            // 
            // Fbimode
            // 
            this.Fbimode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fbimode.AutoSize = true;
            this.Fbimode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fbimode.Location = new System.Drawing.Point(666, 124);
            this.Fbimode.Name = "Fbimode";
            this.Fbimode.Size = new System.Drawing.Size(97, 20);
            this.Fbimode.TabIndex = 3;
            this.Fbimode.Text = "Delete Files";
            this.Fbimode.UseVisualStyleBackColor = true;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsPanel.Controls.Add(this.ADLshortcut);
            this.SettingsPanel.Controls.Add(this.SaveSlotLabel);
            this.SettingsPanel.Controls.Add(this.SaveSlot);
            this.SettingsPanel.Controls.Add(this.DelayNum);
            this.SettingsPanel.Controls.Add(this.DelayLabel);
            this.SettingsPanel.Controls.Add(this.Generate);
            this.SettingsPanel.Controls.Add(this.consoletoggle);
            this.SettingsPanel.Controls.Add(this.Pause);
            this.SettingsPanel.Controls.Add(this.Fbimode);
            this.SettingsPanel.Location = new System.Drawing.Point(8, 107);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(778, 269);
            this.SettingsPanel.TabIndex = 4;
            // 
            // ADLshortcut
            // 
            this.ADLshortcut.Location = new System.Drawing.Point(3, 5);
            this.ADLshortcut.Name = "ADLshortcut";
            this.ADLshortcut.Size = new System.Drawing.Size(118, 27);
            this.ADLshortcut.TabIndex = 7;
            this.ADLshortcut.Text = "App data logger";
            this.ADLshortcut.UseVisualStyleBackColor = true;
            this.ADLshortcut.Click += new System.EventHandler(this.ADLshortcut_Click);
            // 
            // SaveSlotLabel
            // 
            this.SaveSlotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSlotLabel.AutoSize = true;
            this.SaveSlotLabel.Location = new System.Drawing.Point(668, 56);
            this.SaveSlotLabel.Name = "SaveSlotLabel";
            this.SaveSlotLabel.Size = new System.Drawing.Size(66, 16);
            this.SaveSlotLabel.TabIndex = 5;
            this.SaveSlotLabel.Text = "Save slot:";
            // 
            // SaveSlot
            // 
            this.SaveSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSlot.Location = new System.Drawing.Point(669, 75);
            this.SaveSlot.Name = "SaveSlot";
            this.SaveSlot.Size = new System.Drawing.Size(100, 22);
            this.SaveSlot.TabIndex = 6;
            // 
            // DelayNum
            // 
            this.DelayNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayNum.Location = new System.Drawing.Point(668, 31);
            this.DelayNum.Name = "DelayNum";
            this.DelayNum.Size = new System.Drawing.Size(100, 22);
            this.DelayNum.TabIndex = 6;
            this.DelayNum.Text = "2000";
            this.DelayNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelayNum_KeyPress);
            // 
            // DelayLabel
            // 
            this.DelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(668, 12);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(75, 16);
            this.DelayLabel.TabIndex = 5;
            this.DelayLabel.Text = "Delay (ms):";
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate.Location = new System.Drawing.Point(671, 220);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(99, 46);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "Generate file(s)";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // consoletoggle
            // 
            this.consoletoggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.consoletoggle.AutoSize = true;
            this.consoletoggle.Checked = true;
            this.consoletoggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consoletoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consoletoggle.Location = new System.Drawing.Point(666, 173);
            this.consoletoggle.Name = "consoletoggle";
            this.consoletoggle.Size = new System.Drawing.Size(109, 20);
            this.consoletoggle.TabIndex = 3;
            this.consoletoggle.Text = "Show console";
            this.consoletoggle.UseVisualStyleBackColor = true;
            // 
            // Pause
            // 
            this.Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pause.AutoSize = true;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Location = new System.Drawing.Point(666, 147);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(104, 20);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Pause at end";
            this.Pause.UseVisualStyleBackColor = true;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Settingstab);
            this.Tabs.Controls.Add(this.Loggertab);
            this.Tabs.Controls.Add(this.Logtab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.HotTrack = true;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(800, 413);
            this.Tabs.TabIndex = 5;
            // 
            // Settingstab
            // 
            this.Settingstab.BackColor = System.Drawing.SystemColors.Control;
            this.Settingstab.Controls.Add(this.SettingsPanel);
            this.Settingstab.Controls.Add(this.Directories);
            this.Settingstab.Controls.Add(this.TF2Man);
            this.Settingstab.Location = new System.Drawing.Point(4, 25);
            this.Settingstab.Name = "Settingstab";
            this.Settingstab.Padding = new System.Windows.Forms.Padding(3);
            this.Settingstab.Size = new System.Drawing.Size(792, 384);
            this.Settingstab.TabIndex = 0;
            this.Settingstab.Text = "Settings";
            // 
            // Loggertab
            // 
            this.Loggertab.BackColor = System.Drawing.SystemColors.Control;
            this.Loggertab.Controls.Add(this.settingstogglelabel);
            this.Loggertab.Controls.Add(this.modetoggle);
            this.Loggertab.Controls.Add(this.launchapptoggle);
            this.Loggertab.Controls.Add(this.Blacklistlabel);
            this.Loggertab.Controls.Add(this.ScanpathLabel);
            this.Loggertab.Controls.Add(this.blacklist);
            this.Loggertab.Controls.Add(this.fetchlist);
            this.Loggertab.Controls.Add(this.ScannerButton);
            this.Loggertab.Controls.Add(this.fetchpath);
            this.Loggertab.Location = new System.Drawing.Point(4, 25);
            this.Loggertab.Name = "Loggertab";
            this.Loggertab.Padding = new System.Windows.Forms.Padding(3);
            this.Loggertab.Size = new System.Drawing.Size(792, 384);
            this.Loggertab.TabIndex = 2;
            this.Loggertab.Text = "App Data Logger";
            // 
            // launchapptoggle
            // 
            this.launchapptoggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.launchapptoggle.AutoSize = true;
            this.launchapptoggle.Checked = true;
            this.launchapptoggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.launchapptoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchapptoggle.Location = new System.Drawing.Point(673, 33);
            this.launchapptoggle.Name = "launchapptoggle";
            this.launchapptoggle.Size = new System.Drawing.Size(95, 20);
            this.launchapptoggle.TabIndex = 15;
            this.launchapptoggle.Text = "Launch app";
            this.launchapptoggle.UseVisualStyleBackColor = true;
            // 
            // Blacklistlabel
            // 
            this.Blacklistlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Blacklistlabel.AutoSize = true;
            this.Blacklistlabel.Location = new System.Drawing.Point(673, 94);
            this.Blacklistlabel.Name = "Blacklistlabel";
            this.Blacklistlabel.Size = new System.Drawing.Size(60, 16);
            this.Blacklistlabel.TabIndex = 14;
            this.Blacklistlabel.Text = "Blacklist:";
            // 
            // ScanpathLabel
            // 
            this.ScanpathLabel.AutoSize = true;
            this.ScanpathLabel.Location = new System.Drawing.Point(6, 11);
            this.ScanpathLabel.Name = "ScanpathLabel";
            this.ScanpathLabel.Size = new System.Drawing.Size(70, 16);
            this.ScanpathLabel.TabIndex = 13;
            this.ScanpathLabel.Text = "Scan path:";
            // 
            // blacklist
            // 
            this.blacklist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blacklist.BackColor = System.Drawing.Color.Black;
            this.blacklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blacklist.ForeColor = System.Drawing.Color.Red;
            this.blacklist.Location = new System.Drawing.Point(675, 113);
            this.blacklist.Multiline = true;
            this.blacklist.Name = "blacklist";
            this.blacklist.Size = new System.Drawing.Size(117, 205);
            this.blacklist.TabIndex = 12;
            // 
            // fetchlist
            // 
            this.fetchlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fetchlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fetchlist.FormattingEnabled = true;
            this.fetchlist.ItemHeight = 16;
            this.fetchlist.Location = new System.Drawing.Point(6, 58);
            this.fetchlist.Name = "fetchlist";
            this.fetchlist.Size = new System.Drawing.Size(661, 320);
            this.fetchlist.TabIndex = 9;
            this.fetchlist.SelectedIndexChanged += new System.EventHandler(this.fetchlist_SelectedIndexChanged);
            // 
            // ScannerButton
            // 
            this.ScannerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScannerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScannerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScannerButton.Location = new System.Drawing.Point(672, 324);
            this.ScannerButton.Name = "ScannerButton";
            this.ScannerButton.Size = new System.Drawing.Size(117, 60);
            this.ScannerButton.TabIndex = 11;
            this.ScannerButton.Text = "Run";
            this.ScannerButton.UseVisualStyleBackColor = true;
            this.ScannerButton.Click += new System.EventHandler(this.ScannerButton_Click);
            // 
            // fetchpath
            // 
            this.fetchpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fetchpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fetchpath.Location = new System.Drawing.Point(6, 30);
            this.fetchpath.Name = "fetchpath";
            this.fetchpath.Size = new System.Drawing.Size(661, 22);
            this.fetchpath.TabIndex = 10;
            this.fetchpath.Text = "%appdata%";
            // 
            // Logtab
            // 
            this.Logtab.BackColor = System.Drawing.SystemColors.Control;
            this.Logtab.Controls.Add(this.GeneralLog);
            this.Logtab.Location = new System.Drawing.Point(4, 25);
            this.Logtab.Name = "Logtab";
            this.Logtab.Padding = new System.Windows.Forms.Padding(3);
            this.Logtab.Size = new System.Drawing.Size(792, 384);
            this.Logtab.TabIndex = 1;
            this.Logtab.Text = "Log";
            // 
            // modetoggle
            // 
            this.modetoggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modetoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modetoggle.Location = new System.Drawing.Point(673, 57);
            this.modetoggle.Name = "modetoggle";
            this.modetoggle.Size = new System.Drawing.Size(116, 28);
            this.modetoggle.TabIndex = 16;
            this.modetoggle.Text = "Mode: Apply";
            this.modetoggle.UseVisualStyleBackColor = true;
            this.modetoggle.Click += new System.EventHandler(this.modetoggle_Click);
            // 
            // settingstogglelabel
            // 
            this.settingstogglelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingstogglelabel.AutoSize = true;
            this.settingstogglelabel.Location = new System.Drawing.Point(670, 11);
            this.settingstogglelabel.Name = "settingstogglelabel";
            this.settingstogglelabel.Size = new System.Drawing.Size(106, 16);
            this.settingstogglelabel.TabIndex = 17;
            this.settingstogglelabel.Text = "Settings toggles:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.Tabs);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PAPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TF2Man)).EndInit();
            this.Directories.ResumeLayout(false);
            this.Directories.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.Settingstab.ResumeLayout(false);
            this.Loggertab.ResumeLayout(false);
            this.Loggertab.PerformLayout();
            this.Logtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TF2Man;
        private System.Windows.Forms.RichTextBox GeneralLog;
        private System.Windows.Forms.Panel Directories;
        private System.Windows.Forms.Label appdatalabel;
        private System.Windows.Forms.Label apppathlabel;
        private System.Windows.Forms.Button exepathbrowse;
        private System.Windows.Forms.TextBox exepath;
        private System.Windows.Forms.Button appdatapathbrowse;
        private System.Windows.Forms.TextBox appdatapath;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.CheckBox Fbimode;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.CheckBox Pause;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.TextBox DelayNum;
        private System.Windows.Forms.CheckBox consoletoggle;
        private System.Windows.Forms.Label SaveSlotLabel;
        private System.Windows.Forms.TextBox SaveSlot;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Settingstab;
        private System.Windows.Forms.TabPage Logtab;
        private System.Windows.Forms.TabPage Loggertab;
        private System.Windows.Forms.Button ADLshortcut;
        private System.Windows.Forms.TextBox blacklist;
        private System.Windows.Forms.ListBox fetchlist;
        private System.Windows.Forms.Button ScannerButton;
        private System.Windows.Forms.TextBox fetchpath;
        private System.Windows.Forms.Label Blacklistlabel;
        private System.Windows.Forms.Label ScanpathLabel;
        private System.Windows.Forms.CheckBox launchapptoggle;
        private System.Windows.Forms.Button modetoggle;
        private System.Windows.Forms.Label settingstogglelabel;
    }
}

