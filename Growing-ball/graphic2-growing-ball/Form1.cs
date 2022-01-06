using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphic2_growing_ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        int c = 0;
        int time = 0;
        int killed_count = 0;
        List<place> t_places = new List<place>();
        
        class place
        {
            public Point location = new Point(100,50);
            public String name;
            public int vx = 7;
            public int vy = 7;
            public int r = 5;
            public SolidBrush brush;
        }

        private SolidBrush pickBrush()
        {
            Random rnd = new Random();
            Color c = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

            SolidBrush brush = new SolidBrush(c);
            return brush;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            time_now.Text = ((double)time/10.0).ToString();

            if (time % 20 == 0)
            {
                place myplace = new place();
                c++;
                myplace.brush = pickBrush();
                myplace.name = c.ToString();
                t_places.Add(myplace);
            }
            foreach(place myplace in t_places) {
                myplace.location.X += myplace.vx;
                myplace.location.Y += myplace.vy;

                if (myplace.location.Y+myplace.r > pictureBox2.Height)
                {
                    myplace.location.Y -= myplace.vy;
                    myplace.vy *= -1;
                    myplace.r += 5;
                }

                else if (myplace.location.Y - myplace.r <= 0)
                {
                    myplace.location.Y -= myplace.vy;
                    myplace.vy *= -1;
                }

                else if (myplace.location.X + myplace.r > pictureBox2.Width)
                {
                    myplace.location.X -= myplace.vx;
                    myplace.vx *= -1;
                }

                else if (myplace.location.X - myplace.r <= 0)
                {
                    myplace.location.X -= myplace.vx;
                    myplace.vx *= -1;
                }
            }

            Refresh();


        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

            private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            place myplace = new place();
            c++;
            myplace.name = c.ToString();
            myplace.brush = pickBrush();
            t_places.Add(myplace);

            Refresh();
        }
      



        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(place myplace in t_places) {
                
                g.FillEllipse(myplace.brush, myplace.location.X - myplace.r, myplace.location.Y - myplace.r, 2 * myplace.r, 2 * myplace.r);
                g.DrawString(myplace.name, Font, Brushes.Black, myplace.location) ;
            }
        }

        private void toTheRight_Click(object sender, EventArgs e)
        {
            foreach (place myplace in t_places)
            {
                myplace.vx++;
            }
        }

        private void toTheLeft_Click(object sender, EventArgs e)
        {
            foreach (place myplace in t_places)
            {
                myplace.vx--;
            }
        }

       

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < t_places.Count; i++)
            {
                if (Math.Pow(e.X - (t_places[i].location.X ), 2) + Math.Pow(e.Y - (t_places[i].location.Y), 2) <= Math.Pow(t_places[i].r, 2))
                {
                    t_places.RemoveAt(i);
                    Refresh();
                    killed_count++;
                    killed.Text = killed_count.ToString();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            t_places.Clear();
            time = 0;
            killed_count = 0;
            Refresh();
            timer1.Stop();
            time_now.Text = "0.0";
            killed.Text = "0";
            c = 0;
        }
    }
}
