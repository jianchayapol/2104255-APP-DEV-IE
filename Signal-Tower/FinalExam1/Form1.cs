using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Width = 480;
            pictureBox1.Height = 480;
            this.Height = 600;
            this.Width = 750;
            showform2.Enabled = true;
            button1.Enabled = false;
        }

        List<SignalPoint> collection = new List<SignalPoint>();
        

        class SignalPoint
        {
            public Point p;
            public int radius;
            public bool isPress;
            public SignalPoint(Point p, int radius)
            {
                this.p = p;
                this.radius = radius;
                this.isPress = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            int x, y, r;
            bool isValidX = int.TryParse(textBox1.Text, out x);
            bool isValidY = int.TryParse(textBox2.Text, out y);
            bool isValidR = int.TryParse(textBox3.Text, out r);

            if (isValidR && isValidX && isValidY)
            {
                SignalPoint tmp = new SignalPoint(new Point(x, y), r);
                collection.Add(tmp);
                form2.setTowerNumber(collection.Count);
            }
            else
            {
                MessageBox.Show("Please input in the correct format of Integer");
            }

            Refresh();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            outputSignal.Clear();
            foreach(SignalPoint sp in collection)
            {
                outputSignal.Text += ("("+sp.p.X+","+sp.p.Y+")"+ " R=" +sp.radius+ "\r\n");
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0;
            Graphics g = e.Graphics;
            foreach (SignalPoint sp in collection)
            {
                g.FillEllipse(Brushes.LightCyan, sp.p.X - sp.radius , sp.p.Y - sp.radius, sp.radius * 2, sp.radius * 2);
                
            }
            foreach (SignalPoint sp in collection)
            {
                i++;
               if(sp.isPress==false) g.FillEllipse(Brushes.DarkCyan, sp.p.X-10, sp.p.Y-10, 20, 20);
               else { g.FillEllipse(Brushes.Yellow, sp.p.X-10, sp.p.Y-10, 20, 20); }
                g.DrawString(i.ToString(), Font, Brushes.Black, sp.p.X-5, sp.p.Y-5);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int i;
            for( i = 0; i < collection.Count; i++)
            {
                if(Math.Sqrt(Math.Pow(e.X-collection[i].p.X,2)+ Math.Pow(e.Y - collection[i].p.Y, 2))<= 10)
                {
                    collection[i].isPress = true;
                    Refresh();
                    break;
                }
            }
        }

        bool isStart = false;
        private void delete_Click(object sender, EventArgs e)
        {
           for(int i = collection.Count-1; i>=0; i--)
            {
                if (collection[i].isPress) collection.RemoveAt(i);
            }
            form2.setTowerNumber(collection.Count);
            Refresh();
            outputSignal.Clear();
            foreach (SignalPoint sp in collection)
            {
                outputSignal.Text += ("(" + sp.p.X + "," + sp.p.Y + ")" + " R=" + sp.radius + "\r\n");
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //xy.Text = e.X.ToString() + " " + e.Y.ToString();
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            timeLabel.Text = ((double)time / 10.0).ToString();
            if (time % 5 == 0)
            {
                int ranX = random.Next(0,pictureBox1.Width+1);
                int ranY = random.Next(0, pictureBox1.Height + 1);
                var list = new List<int> { 50,100,150,200 };
                int index = random.Next(list.Count);
                int ranR = list[index];
                collection.Add(new SignalPoint(new Point(ranX, ranY), ranR));
                
            }
            form2.setTowerNumber(collection.Count);
            if (collection.Count == 10) timer1.Stop();
            Refresh();
        }
        int time = 0;
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isStart = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            System.IO.StreamWriter writer = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new System.IO.StreamWriter(saveFileDialog1.FileName);

                foreach (SignalPoint sp in collection)
                {
                    writer.Write(sp.p.X.ToString() + "," + sp.p.Y.ToString() + ","+sp.radius.ToString() + "\r\n");
                }
                writer.Close();
            }
        }



        private void importButton_Click(object sender, EventArgs e)
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
                    int r = Int16.Parse(line.Split(',')[2]);
                    if (line != "\r\n") collection.Add(new SignalPoint(new Point(x,y),r));
                }

                Refresh();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            isStart = false;
            timer1.Stop();
        }

        private void showform2_Click(object sender, EventArgs e)
        {
            form2.Show();
            showform2.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Hide();
            showform2.Enabled = true;
            button1.Enabled = false;
        }

        

        private void removeOverlapTower_Click(object sender, EventArgs e)
        {
            List<SignalPoint> tmp = new List<SignalPoint>();
           
            if (collection.Count > 0)
            {
                tmp.Add(collection[0]);

                for (int i = 1; i < collection.Count; i++)
                {
                    bool check = false;

                    for (int j = 0; j < tmp.Count; j++)
                    {
                        if (isOverlap(collection[i], tmp[j]) && tmp[j].Equals(collection[i]) == false) { check = true; break; }
                    }

                    if (check == false) tmp.Add(collection[i]);

                }
            }
            collection = tmp;
            outputSignal.Clear();
            foreach (SignalPoint sp in collection)
            {
                outputSignal.Text += ("(" + sp.p.X + "," + sp.p.Y + ")" + " R=" + sp.radius + "\r\n");
            }

            Refresh();

        }

        private bool isOverlap(SignalPoint sp1, SignalPoint sp2)
        {
            return (Math.Sqrt(Math.Pow(sp1.p.X - sp2.p.X, 2) + Math.Pow(sp1.p.Y - sp2.p.Y, 2)) < sp1.radius + sp2.radius);
        }
    }
}
