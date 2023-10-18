namespace portable_app_progress_saver
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
            this.apppathlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appdatalabel = new System.Windows.Forms.Label();
            this.exepath = new System.Windows.Forms.TextBox();
            this.exepathbrowse = new System.Windows.Forms.Button();
            this.appdatapath = new System.Windows.Forms.TextBox();
            this.appdatapathbrowse = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.apppathlabel);
            this.panel1.Location = new System.Drawing.Point(115, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 95);
            this.panel1.TabIndex = 2;
            // 
            // apppathlabel
            // 
            this.apppathlabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.apppathlabel.AutoSize = true;
            this.apppathlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apppathlabel.Location = new System.Drawing.Point(4, 16);
            this.apppathlabel.Name = "apppathlabel";
            this.apppathlabel.Size = new System.Drawing.Size(96, 20);
            this.apppathlabel.TabIndex = 3;
            this.apppathlabel.Text = "Executable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // appdatalabel
            // 
            this.appdatalabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appdatalabel.AutoSize = true;
            this.appdatalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appdatalabel.Location = new System.Drawing.Point(4, 47);
            this.appdatalabel.Name = "appdatalabel";
            this.appdatalabel.Size = new System.Drawing.Size(123, 20);
            this.appdatalabel.TabIndex = 3;
            this.appdatalabel.Text = "App Data Path:";
            // 
            // exepath
            // 
            this.exepath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exepath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exepath.Location = new System.Drawing.Point(106, 6);
            this.exepath.Name = "exepath";
            this.exepath.Size = new System.Drawing.Size(476, 31);
            this.exepath.TabIndex = 4;
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
            this.appdatapath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appdatapath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appdatapath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appdatapath.Location = new System.Drawing.Point(132, 43);
            this.appdatapath.Name = "appdatapath";
            this.appdatapath.Size = new System.Drawing.Size(450, 31);
            this.appdatapath.TabIndex = 4;
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
            // openfile
            // 
            this.openfile.Filter = "Common Executables|*.EXE|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appdatalabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label apppathlabel;
        private System.Windows.Forms.Button exepathbrowse;
        private System.Windows.Forms.TextBox exepath;
        private System.Windows.Forms.Button appdatapathbrowse;
        private System.Windows.Forms.TextBox appdatapath;
        private System.Windows.Forms.OpenFileDialog openfile;
    }
}

