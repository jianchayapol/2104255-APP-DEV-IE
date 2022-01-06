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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void addPassword(string s)
        {
            label1.Text += (s+" "); 
        }
        public void clearPassword()
        {
            label1.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
