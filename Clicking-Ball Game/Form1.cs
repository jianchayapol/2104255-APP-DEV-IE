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


namespace sampleQuiz1
{
    public partial class Form1 : Form
    {
        double time=0;
        List<Point> collection = new List<Point>();

        Form2 form2 = new Form2();
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = core.data.get_color();
            form2.Show();
            show.Enabled = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            collection.Clear();
            timer1.Start();
            int px = randm.Next(0, 321);
            int py = randm.Next(0, 321);

            collection.Add(new Point(px, py));
            label2.Text = collection.Count().ToString();
            Refresh();
        }

        Random randm = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = ((double)time / 10.0).ToString();
            //label1.Text = ((int)time / 10).ToString();
            if (time % 5 == 0)
            {
                int px = randm.Next(0, 321);
                int py = randm.Next(0, 321);
                
                collection.Add(new Point(px, py));
                label2.Text = collection.Count().ToString();
                form2.setText(collection.Count().ToString());
            }

            Refresh();

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Point b in collection)
            {
                g.FillEllipse(Brushes.SeaGreen, b.X-10, b.Y-10, 20, 20);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (Math.Pow(e.X - (collection[i].X), 2) + Math.Pow(e.Y - (collection[i].Y), 2) <= Math.Pow(10, 2))
                {
                    collection.RemoveAt(i);
                    label2.Text = collection.Count.ToString();
                    form2.setText(collection.Count().ToString()); 
                    Refresh();
                }
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            form2.Hide();
            show.Enabled = true;
            hide.Enabled = false;
        }

        public void hideform()
        {
            this.show.Enabled = true;
            this.hide.Enabled = false;
        }

        private void show_Click(object sender, EventArgs e)
        {
            form2.Show();
            show.Enabled = false;
            hide.Enabled = true;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void save_Click(object sender, EventArgs e)
        {
                timer1.Stop();
                System.IO.StreamWriter writer = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    writer = new System.IO.StreamWriter(saveFileDialog1.FileName);
                    
                    foreach (Point p in collection)
                    {
                        writer.Write(p.X.ToString() + ","+p.Y.ToString()+"\r\n");
                    }
                    writer.Close();
                }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Open CSV File";
                dialog.Filter = "CSV Files (*.csv)|*.csv";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filename = dialog.FileName;
                }
                else return;
                

                // Read a text file line by line.  
                string[] lines = System.IO.File.ReadAllLines(filename);

                collection.Clear();

                foreach (string line in lines)
                {
                    int x = Int16.Parse(line.Split(',')[0]);
                    int y = Int16.Parse(line.Split(',')[1]);
                    if (line != "\r\n") collection.Add(new Point(x, y));
                }
                pictureBox2.Refresh();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void breakball_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
