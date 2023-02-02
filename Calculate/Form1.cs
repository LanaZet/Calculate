using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{ 

public partial class Calculator : Form
    {
        public Operand num1 = new Operand();
        public Operand num2 = new Operand();
        public string lastOper;

        public Calculator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lastOper == "=")
            {
                textPanel.Clear();
                lastOper = "";
            }
            textPanel.Text += (sender as Button).Text;
        }
        
        public void buttonPlus_Click(object sender, EventArgs e)
        {
            if (num2.getRaw() != "")
            {
                lastOper = (sender as Button).Text;
                buttonShowResult_Click(sender, e);
            }

            else 
            {
                num1.update(textPanel.Text);
                lastOper = (sender as Button).Text;
                textPanel.Clear();
            }
        }
        public void buttonShowResult_Click(object sender, EventArgs e)
        {
            num2.update(textPanel.Text);
            textPanel.Text = Convert.ToString(calculate(num1.getData(), lastOper, num2.getData()));
            lastOper = "=";
            num1.clear();
            num2.clear();
        }
        public double calculate(double num1, string op, double num2) 
        {
            if (op == "+")
            {
                return num1 + num2;
            }

            else if (op == "-")
            {
                return num1 - num2;
            }

            else if (op == "*")
            {
                return num1 * num2;
            }

            else if (op == "/")
            {
                return num1 / num2;
            }
            else if (op == "%") 
            {
                return (num1 * num2) / 100;
            }
            return num1;
        }
        private void buttonCkear_Click(object sender, EventArgs e)
        {
            textPanel.Text = "";
            num1.clear();
            num2.clear();
            lastOper = "";

        }
        private void buttonNegativeNumber_Click(object sender, EventArgs e)
        {
            if (textPanel.Text != " ") 
            {
                if (textPanel.Text == "-")
                {
                    textPanel.Text.Remove(0, 1);
                }
                else 
                {
                    
                   textPanel.Text = textPanel.Text = '-' + textPanel.Text;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textPanel.Text != "") 
            {
                textPanel.Text = textPanel.Text.Remove(textPanel.Text.Length -1, 1);
            }
        }

    }


}
