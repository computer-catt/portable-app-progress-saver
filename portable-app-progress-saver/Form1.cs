using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portable_app_progress_saver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox1.BackgroundImage = Bitmap.FromStream(WebRequest.Create("https://cdn.discordapp.com/attachments/1104813377836036237/1164212783307571350/IMG_1945.jpg").GetResponse().GetResponseStream());
            }
            catch 
            {
                pictureBox1.Hide();
                panel1.Location = pictureBox1.Location;
            }
        }

        private void exepathbrowse_Click(object sender, EventArgs e)
        {
            if (openfile.ShowDialog() == DialogResult.OK) 
                exepath.Text = openfile.FileName;
        }

        private void appdatapathbrowse_Click(object sender, EventArgs e)
        {
            openfolder openfolder = new openfolder();
            openfolder.Multiselect = false;
            if (openfolder.ShowDialog(IntPtr.Zero) == true)
            {
                appdatapath.Text = openfolder.ResultPath;
            }
        }
    }
}
