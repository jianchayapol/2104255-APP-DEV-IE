using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic3_captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap original = null;

        private void upload_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 10;
            progressBar1.Value = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(openFileDialog1.FileName);
                //pictureBox1.Image = bm;
                original = bm;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = bm;

                //Bitmap bm2 = new Bitmap(bm, pictureBox1.Size);
                //pictureBox1.Image = bm2;

            }
        }

        Color target;
        private void run_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("File Not Found!");
                return;
            }


            


            // Bitmap bm = (Bitmap)pictureBox1.Image;

            Bitmap bm = original;
            
            Dictionary<Color, int> data = new Dictionary<Color, int>();
            

            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    Color c = bm.GetPixel(i, j);
                    //string color = c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString();
                    if (data.ContainsKey(c)) data[c]++;
                    else data.Add(c, 1);
                }
            }
            int second_found = data.Values.OrderByDescending(z => z).Skip(1).First();

            foreach(Color n in data.Keys)
            {
                if (data[n] == second_found) target = n;
            }

            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    if (progressBar1.Value < progressBar1.Maximum) progressBar1.Value++;
                    Color c = bm.GetPixel(i, j);
                    //label1.Text = target.R.ToString() + target.G.ToString() + target.B.ToString();
                    if (c.R == target.R && c.G == target.G && c.B == target.B)  bm.SetPixel(i, j, Color.FromArgb(0,0,0));
                    else bm.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                }

            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //Bitmap bm2 = new Bitmap(bm, pictureBox1.Size);
            pictureBox1.Image = bm;

            pictureBox1.Refresh();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image == null) return;

                Bitmap bm = (Bitmap)pictureBox1.Image;
                bm.Save(saveFileDialog1.FileName);
                //original.Save(saveFileDialog1.FileName);


            }
        }
    }
}
