using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public static long ToUnixTimestamp(DateTime target)
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            var unixTimestamp = System.Convert.ToInt64((target - date).TotalSeconds);

            return unixTimestamp;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string title_in = title.Text;
            string desc_in = desc.Text;
            String due_date = dateTimePicker1.Value.ToLongDateString();
            long due_unix = ToUnixTimestamp(dateTimePicker1.Value);
            string subject_in = subject.Text;
            string url_in = url.Text;
            int priority_in = (int) numericUpDown1.Value;

            string s;
            List<string> csvLines = new List<string>();

            StreamReader sr = new StreamReader("lists-to-do.csv");
            
            while ((( s = sr.ReadLine()) != null)) //null = all files are read.
            {
                csvLines.Add(s);
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("lists-to-do.csv");
            foreach (string line in csvLines)
            {
                sw.Write(line + "\r\n");
            }

            title_in = title_in.Replace(",", " ");
            desc_in = desc_in.Replace(",", " ");
            url_in = url_in.Replace(",", " ");
            if (url_in == "-" || url_in == " ") url_in = "";
            subject_in = subject_in.Replace(",", " ");

            sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}",subject_in, title_in, desc_in, priority_in,due_unix,"waiting..",url_in);
            sw.Close();
            
            title.Text= "";
            desc.Text = "";
            subject.Text="";
            url.Text = "";
            numericUpDown1.Value = 0;
            MessageBox.Show("Successfully Added!");
            this.Close();
            return;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void url_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
