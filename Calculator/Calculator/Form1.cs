using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
        }

        double answer = 0;
        string operation = "+";

        void addNumber(string n)
        {
            if (preResult.Text == "0")
            {
                preResult.Text = n;
            }
            else preResult.Text += n;
        }

        void triggerEvent(string operation)
        {
            if (operation == "+") answer += double.Parse(preResult.Text);
            else if (operation == "-") answer -= double.Parse(preResult.Text);
        }

        void operate(string op)
        {
            if (preResult.Text == "") return;
            triggerEvent(operation);
            preResult.Text = "";
            operation = op;
            opr.Text = op;
            result.Text = answer.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            operate("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operate("-");
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (preResult.Text == "") return;

            triggerEvent(operation);
            preResult.Text = answer.ToString();
            result.Text = answer.ToString();
            operation = "";
            opr.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            preResult.Text += ".";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            preResult.Text = "";
            result.Text = "";
            answer = 0;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (preResult.Text.Length > 0)
                preResult.Text = preResult.Text.Substring(0, preResult.Text.Length - 1);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            addNumber("0");
        }

        private void one_Click(object sender, EventArgs e)
        {
            addNumber("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            addNumber("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            addNumber("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            addNumber("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            addNumber("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            addNumber("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            addNumber("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            addNumber("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            addNumber("9");
        }

    }

    
}
