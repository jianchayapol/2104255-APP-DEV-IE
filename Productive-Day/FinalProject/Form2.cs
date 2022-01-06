using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void showDesc(string title, string desc)
        {
            pictureBoxQR.Image = null;
            label1.Text = (" Title: " + title);
            label2.Text = (" Description: " + desc);
        }

        public void showQRform2(Bitmap picture)
        {
            Bitmap x = new Bitmap(picture, pictureBoxQR.Size);
            pictureBoxQR.Image = x;
        }






        private void pictureBoxQR_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBoxQR_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureBoxQR.Image = null;
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            string d = DateTime.Now.ToShortDateString();
            sfd.FileName = "desc_" + d.Replace("/", "-") + ".png";

            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }

                    bmp.Save(sfd.FileName, format);
                }
           
            }
        }
    }
}
