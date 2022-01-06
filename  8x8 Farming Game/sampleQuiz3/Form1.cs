using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleQuiz3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Height = 400;
            pictureBox1.Width = 400;
            this.Width = 600;
            this.Height = 500;
            label2.ForeColor = Color.BlueViolet;
        }

        int time = 0;

        private void start_Click(object sender, EventArgs e)
        {
            collection.Clear();
            time = 0;
            timer1.Start();
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for(int i=0; i < 400 ; i+= 50)
            {
                g.DrawLine(Pens.Gray, new Point(0, i), new Point(400, i));
            }
            for (int i = 0; i < 400; i += 50)
            {
                g.DrawLine(Pens.Gray, new Point(i, 0), new Point(i,400));
            }

            foreach(Point p in collection.Keys)
            {
                string t = collection[p];
                if (t.Equals("grass"))
                {
                    g.DrawString(t, new Font("Arial", 10), Brushes.Green, p.X*50 +7, p.Y*50 +15);
                }
                else if (t.Equals("bug"))
                {
                    g.DrawString(t, new Font("Arial", 10), Brushes.Gold, p.X*50 +10, p.Y*50 +15);
                }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = ((double)time / 10.0).ToString();
            if (time % 5 == 0)
            {
                fillWord();

                if (collection.Count == 64)
                {
                    MessageBox.Show("ENDED");
                    timer1.Stop();
                }
            }
                Refresh();
        }

        Random random = new Random();

        Dictionary<Point, string> collection = new Dictionary<Point, string>();
        


        public void fillWord()
        {
            int i = random.Next(0, 8);
            int j = random.Next(0, 8);

            while (collection.ContainsKey(new Point(i,j)) && collection.Count <= 64)
            {
                i = random.Next(0, 8);
                j = random.Next(0, 8);
            }

            Point tmp = new Point(i, j);

            int idx = random.Next(0, 2);
            if (idx % 2 == 0)
            {
                collection.Add(tmp, "grass");
            }
            else
            {
                collection.Add(tmp, "bug");
            }

        }

        bool isYaKaYa = false;

        private void button1_Click(object sender, EventArgs e)
        {
            isYaKaYa = !isYaKaYa;
            if (isYaKaYa)
            {
                label2.Text = "ยาฆ่าหญ้า";
                label2.ForeColor = Color.Red;
                button1.Text = "เปลี่ยนเป็นยาฆ่าแมลง";
            }
            else
            {
                label2.Text = "ยาฆ่าแมลง";
                label2.ForeColor = Color.BlueViolet;
                button1.Text = "เปลี่ยนเป็นยาฆ่าหญ้า";
            }

            }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string ya;
            if (isYaKaYa) ya = "grass";
            else ya = "bug";
            int x = (e.X / 50);
            int y = (e.Y / 50);

            Point tmp = new Point(x, y);

            //MessageBox.Show(x.ToString() + " " + y.ToString());

            if (collection.ContainsKey(tmp) && collection[tmp]==ya)
            {
                collection.Remove(tmp);
            }

            //MessageBox.Show(e.X.ToString() + " " + e.Y.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void upload_Click(object sender, EventArgs e)
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
                    string text = line.Split(',')[2];
                    if (line != "\r\n") collection.Add(new Point(x, y),text);
                }
                pictureBox1.Refresh();

            }
            catch (Exception)
            {
                throw;
            }
        }


        private void save_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            System.IO.StreamWriter writer = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new System.IO.StreamWriter(saveFileDialog1.FileName);

                foreach (Point p in collection.Keys)
                {
                    writer.Write(p.X.ToString() + "," + p.Y.ToString() + "," + collection[p] + "\r\n");
                }
                writer.Close();
            }

        }
    }
}
