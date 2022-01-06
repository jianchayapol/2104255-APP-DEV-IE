using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_approximation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool loop;

        List<Point> points = new List<Point>();
        bool plot = true;
        int totalPointCount = 0;
        int pointInCircle = 0;
        double piEst = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            while (plot)
            {
                int x = rd.Next(225);
                int y = rd.Next(225);
                Point p = new Point(x, y);
                points.Add(p);
                totalPointCount++;

                double d = Math.Sqrt(Math.Pow(x - 112.5, 2) + Math.Pow(y - 112.5, 2));
                if (d <= 112.5) pointInCircle++;

                piEst = 4 * (double) pointInCircle / totalPointCount;

                totalPoint.Text = totalPointCount.ToString();
                inCircle.Text = pointInCircle.ToString();
                label5.Text = "π ≈ " + piEst.ToString();

                Refresh();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.WhiteSmoke, 0, 0, 225, 225);
            g.DrawEllipse(Pens.LightGray, 0,0,225, 225);
            foreach (Point pt in points){
                double d = Math.Sqrt(Math.Pow(pt.X - 112.5, 2) + Math.Pow(pt.Y - 112.5, 2));
                if (d <= 112.5)
                {
                    g.FillEllipse(Brushes.Red, pt.X - 1, pt.Y - 1, 2, 2);
                }
                else
                {
                    g.FillEllipse(Brushes.Blue, pt.X - 1, pt.Y - 1, 2, 2);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void totalPoint_Click(object sender, EventArgs e)
        {

        }

        private void inCircle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
