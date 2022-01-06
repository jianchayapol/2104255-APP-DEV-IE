using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magnifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point point = new Point();
        Form2 form2 = new Form2();
        Bitmap show = null;
        Bitmap bm3 = null;
        bool ball = false;
        class ppixel
        {
            public Point location;
            public Color color;
        }
        List<ppixel> want_to_show = new List<ppixel>();


        private void label1_Click(object sender, EventArgs e)
        {

        }


        Bitmap original = null;


        private void button5_Click(object sender, EventArgs e)
        {
            point.X = 50;
            point.Y = 50;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ball = true;
                Bitmap bm = new Bitmap(openFileDialog1.FileName);
                Bitmap bm2 = new Bitmap(bm, pictureBox1.Size);
                bm3 = bm2;
                show = new Bitmap(bm2, 50, 50);
                pictureBox1.Image = bm2;
                Refresh();

            }
        }


        private void zoom_Click(object sender, EventArgs e)
        {
            form2.Show();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e) // Move right
        {
            if (point.X <= 250)
            {
                point.X += 10;
                Refresh();
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (point.X >= 25)
            {
                point.X -= 10;
                Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (point.Y >= 25)
            {
                point.Y -= 10;
                Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (point.Y <= 250)
            {
                point.Y += 10;
                Refresh();
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawLine(Pens.Blue, point.X - 25, point.Y - 25, point.X + 25, point.Y - 25);
            g.DrawLine(Pens.Blue, point.X + 25, point.Y - 25, point.X + 25, point.Y + 25);
            g.DrawLine(Pens.Blue, point.X + 25, point.Y + 25, point.X - 25, point.Y + 25);
            g.DrawLine(Pens.Blue, point.X - 25, point.Y + 25, point.X - 25, point.Y - 25);

            if (ball)
            {
                bm3 = new Bitmap(pictureBox1.Image, pictureBox1.Size);
                pictureBox1.Image = bm3;
                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        Color tmp = new Color();
                        tmp = bm3.GetPixel(point.X  + i, point.Y + j);
                        show.SetPixel(i, j, tmp);
                       
                    }
                }

                form2.showZoom(show);
                
            }


        }
    }
}
