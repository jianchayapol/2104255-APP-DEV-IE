using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lookpud_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0;
        List<string> pattern = new List<string>();

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        String l(string now)
        {

            if (now.Length == n)
            {

                pattern.Add(now);
                return now;
            }

            l(now + "w");
            l(now + "r");
            if (!now.EndsWith("b")) l(now + "b");
            return now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input.Text, out n))
            {
                n = int.Parse(input.Text);

                l("");
                output.Text = pattern.Count().ToString();
                foreach (string x in pattern)
                {
                    output.Text += ("\r\n"+ x) ;
                }
            }
            else output.Text = "0";
        }
    }
}
