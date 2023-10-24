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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appdatapathbrowse = new System.Windows.Forms.Button();
            this.exepathbrowse = new System.Windows.Forms.Button();
            this.appdatapath = new System.Windows.Forms.TextBox();
            this.exepath = new System.Windows.Forms.TextBox();
            this.appdatalabel = new System.Windows.Forms.Label();
            this.apppathlabel = new System.Windows.Forms.Label();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.Fbimode = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DelayNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.CheckBox();
            this.consoletoggle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveSlot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(665, 290);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.appdatapathbrowse);
            this.panel1.Controls.Add(this.exepathbrowse);
            this.panel1.Controls.Add(this.appdatapath);
            this.panel1.Controls.Add(this.exepath);
            this.panel1.Controls.Add(this.appdatalabel);
            this.panel1.Controls.Add(this.apppathlabel);
            this.panel1.Location = new System.Drawing.Point(115, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 95);
            this.panel1.TabIndex = 2;
            // 
            // appdatapathbrowse
            // 
            this.appdatapathbrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appdatapathbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appdatapathbrowse.Location = new System.Drawing.Point(583, 43);
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
            this.exepathbrowse.Location = new System.Drawing.Point(583, 6);
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
            this.appdatapath.Size = new System.Drawing.Size(450, 31);
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
            this.exepath.Size = new System.Drawing.Size(476, 31);
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
            this.Fbimode.AutoSize = true;
            this.Fbimode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fbimode.Location = new System.Drawing.Point(4, 3);
            this.Fbimode.Name = "Fbimode";
            this.Fbimode.Size = new System.Drawing.Size(97, 20);
            this.Fbimode.TabIndex = 3;
            this.Fbimode.Text = "Delete Files";
            this.Fbimode.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SaveSlot);
            this.panel2.Controls.Add(this.DelayNum);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.consoletoggle);
            this.panel2.Controls.Add(this.Pause);
            this.panel2.Controls.Add(this.Fbimode);
            this.panel2.Location = new System.Drawing.Point(683, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 290);
            this.panel2.TabIndex = 4;
            // 
            // DelayNum
            // 
            this.DelayNum.Location = new System.Drawing.Point(3, 95);
            this.DelayNum.Name = "DelayNum";
            this.DelayNum.Size = new System.Drawing.Size(100, 22);
            this.DelayNum.TabIndex = 6;
            this.DelayNum.Text = "2000";
            this.DelayNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delay (ms):";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate file(s)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pause
            // 
            this.Pause.AutoSize = true;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Location = new System.Drawing.Point(4, 26);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(104, 20);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Pause at end";
            this.Pause.UseVisualStyleBackColor = true;
            // 
            // consoletoggle
            // 
            this.consoletoggle.AutoSize = true;
            this.consoletoggle.Checked = true;
            this.consoletoggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.consoletoggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consoletoggle.Location = new System.Drawing.Point(4, 52);
            this.consoletoggle.Name = "consoletoggle";
            this.consoletoggle.Size = new System.Drawing.Size(109, 20);
            this.consoletoggle.TabIndex = 3;
            this.consoletoggle.Text = "Show console";
            this.consoletoggle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save slot:";
            // 
            // SaveSlot
            // 
            this.SaveSlot.Location = new System.Drawing.Point(4, 139);
            this.SaveSlot.Name = "SaveSlot";
            this.SaveSlot.Size = new System.Drawing.Size(100, 22);
            this.SaveSlot.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PAPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appdatalabel;
        private System.Windows.Forms.Label apppathlabel;
        private System.Windows.Forms.Button exepathbrowse;
        private System.Windows.Forms.TextBox exepath;
        private System.Windows.Forms.Button appdatapathbrowse;
        private System.Windows.Forms.TextBox appdatapath;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.CheckBox Fbimode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Pause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DelayNum;
        private System.Windows.Forms.CheckBox consoletoggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SaveSlot;
    }
}

