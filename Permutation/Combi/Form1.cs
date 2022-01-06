using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<List<string>> test1Ans = new List<List<string>>();
        List<List<string>> test2Ans = new List<List<string>>();

        private int findAndCount(List<string> s, string c)
        {
            int count = 0;
            foreach (string e in s)
            {
                if (e == c) count++;
            }
            return count;
        }

        private List<string> copy(List<string> from, List<string> to)
        {
            foreach(string e in from)
            {
                to.Add(e);
            }
            return to;
        }
        private void sitting(List<string> s)
        {
            if (s.Count() == 10)
            {
                test1Ans.Add(s);
                return;
            }

            if (s.Count() > 1 && s.ElementAt(s.Count() - 1) == "G" && s.ElementAt(s.Count() - 2) != "G")
            {
                if (findAndCount(s, "G") < 5)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("G");
                    sitting(tmp);
                }
            }
            else if (s.Count() == 1 && s.ElementAt(s.Count() - 1) == "G")
            {
                if (findAndCount(s, "G") < 5)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("G");
                    sitting(tmp);
                }
            }

            else if (s.Count() == 9 && s.ElementAt(s.Count() - 1) != "G")
            {
                if (findAndCount(s, "B") < 5)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("B");
                    sitting(tmp);
                }
            }
            else
            {
                if (findAndCount(s, "G") < 5)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s,tmp);
                    tmp.Add("G");
                    sitting(tmp);
                }
                if (findAndCount(s, "B") < 5)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("B");
                    sitting(tmp);
                }
            }
        }

        private void lookkaew(List<string> s)
        {
            if (s.Count() == 7)
            {
                test2Ans.Add(s);
                return;
            }

            // R R , G G ,  W W W 

            if (s.Count() > 0 && s.ElementAt(s.Count() - 1) == "R")
            {
                if (findAndCount(s, "G") < 2)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("G");
                    lookkaew(tmp);
                }
                if (findAndCount(s, "W") < 3)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("W");
                    lookkaew(tmp);
                }
            }
            else if(s.Count() > 0 && s.ElementAt(s.Count() - 1) == "G")
            {
                if (findAndCount(s, "R") < 2)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("R");
                    lookkaew(tmp);
                }
                if (findAndCount(s, "W") < 3)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("W");
                    lookkaew(tmp);
                }
            }

            else if (s.Count() > 0 && s.ElementAt(s.Count() - 1) == "W")
            {
                if (findAndCount(s, "R") < 2)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("R");
                    lookkaew(tmp);
                }
                if (findAndCount(s, "G") < 2)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("G");
                    lookkaew(tmp);
                }
            }

            else
            {
                if (findAndCount(s, "R") < 2)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("R");
                    lookkaew(tmp);
                }
                if (findAndCount(s, "G") < 2)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("G");
                    lookkaew(tmp);
                }
                if (findAndCount(s, "W") < 3)
                {
                    List<string> tmp = new List<string>();
                    tmp = copy(s, tmp);
                    tmp.Add("W");
                    lookkaew(tmp);
                }
            }


        }

        String show_list(List<String> l)
        {
            String output = "{ ";
            for (int i = 0; i < l.Count; i++)
            {
                output += l[i].ToString();
                if(i!=l.Count-1) output += ", ";

            }
            output += " }";

            return output;


        }
        String show_result(List<List<String>> l)
        {
            String output = "จำนวนวิธี  = " + l.Count.ToString() + " วิธี \r\n";
            output += " {\r\n";
            for (int i = 0; i < l.Count; i++)
            {
                output += "    " + show_list(l[i]) + " ,\r\n";

            }
            output += " }\r\n";

            return output;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            test1Ans.Clear();
            List<string> es = new List<string>();
            sitting(es);
            textBox1.Text = show_result(test1Ans);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            test2Ans.Clear();
            List<string> es = new List<string>();
            lookkaew(es);
            textBox1.Text = show_result(test2Ans);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
