using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birthday_prob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        int cases = 1000;
        int count;
        int n;
        Random rd = new Random();

        private bool CheckRandBirth(int n)
        {
            HashSet<int> data = new HashSet<int>();
            
            for (int i=0; i<n; i++)
            {
                data.Add(rd.Next(365));
            }
            return data.Count() != n;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            if (int.TryParse(n_students.Text, out n))
            {
                for(int i=0; i<cases; i++)
                {
                    if (CheckRandBirth(n))
                    {
                        textBox1.Text += "\r\n" + (i + 1).ToString() + "  YES  ";
                        count++;
                    }
                    else
                    {
                        textBox1.Text += "\r\n" + (i + 1).ToString() + "  NO  ";
                    }
                }
                label3.Text = (((double) count / cases) * 100).ToString("0.00") + " %";

            }
            else
            {
                MessageBox.Show("Invalid!");
            }
        }

        private void n_students_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox1.Text = "";
            label3.Text = "0 %";
        }
    }
}
