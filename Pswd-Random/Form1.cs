using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleQuiz2
{
    public partial class Form1 : Form
    {
        int time = 0;
        int k = 9;
        bool isStart = false;

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            form2.Show();
            list1.Clear();
            while (k >= 1) { list1.Add(k); k--; }
            show.Enabled = false;
            hide.Enabled = true;
        }

        List<int> list1 = new List<int>();
        
        private void start_Click(object sender, EventArgs e)
        {
            isStart = true;
            timer1.Start();
            Shuffle<int>(list1);
            Refresh();
            textBox1.Text = "";
            form2.clearPassword();

        }


        public void Shuffle<T>( List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            timeLabel.Text = ((double)time / 10.0).ToString();
            if (time % 200 == 0)
            {
                timer1.Stop();
                time = 0;
                MessageBox.Show("Time's UP");
                textBox2.Clear();
                textBox1.Clear();
                form2.clearPassword();
                timeLabel.Text = "0";
                time = 0;
                isStart = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isStart == true)
            {
                Graphics g = e.Graphics;
                int col_size = (int)(pictureBox1.Width / 3);
                int row_size = (int)(pictureBox1.Height / 3);
                int pos_x = row_size / 6;
                int pos_y = col_size / 6;
                int k = 0;
                while (k <= 8)
                {
                    int j = 3;
                    pos_x = row_size / 6;
                    while (j > 0)
                    {
                        //MessageBox.Show(list1.Count.ToString());
                        g.DrawString((list1[k]).ToString(), new Font("Arial", 72), Brushes.Blue, new Point(pos_x - 10, pos_y - 10));
                        pos_x += col_size;
                        k++;
                        j--;
                    }
                    pos_y += row_size;
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            int col_size = (int)(pictureBox1.Width / 3);
            int row_size = (int)(pictureBox1.Height / 3);
            int idx;

            if(e.X <= col_size) // col 1
            {
                if (e.Y <= row_size) idx = 0;
                else if (e.Y <= row_size * 2) idx = 3;
                else idx = 6;
            }
            else if(e.X <= col_size * 2) // col2
            {
                if (e.Y <= row_size) idx = 1;
                else if (e.Y <= row_size * 2) idx = 4;
                else idx = 7;
            }
            else // col3
            {
                if (e.Y <= row_size) idx = 2;
                else if (e.Y <= row_size * 2) idx = 5;
                else idx = 8;
            }

            form2.addPassword(list1[idx].ToString());
            textBox1.Text += list1[idx];
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            form2.clearPassword();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            form2.Hide();
            hide.Enabled = false;
            show.Enabled = true;
        }

        private void show_Click(object sender, EventArgs e)
        {
            form2.Show();
            show.Enabled = false;
            hide.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new System.IO.StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(textBox2.Text);
                writer.Close();
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
            }
            else return;


            // Read a text file line by line.  
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                if (line != "\r\n") textBox2.Text = line;
            }
        
    }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = core.data.get_code();
        }
    }
}
