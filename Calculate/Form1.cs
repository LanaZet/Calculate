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
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }


public partial class Calculator : Form
    {
        private List<string> containerOfNumbers;

        private List<string> listOfString = new List<string> { "+", "-", "*", "/" };

        public Calculator()
        {
            InitializeComponent();
            containerOfNumbers = new List<string> {};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("1");
            textPanelChange();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("2");
            textPanelChange();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("3");
            textPanelChange();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("4");
            textPanelChange();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("5");
            textPanelChange();
        }
       private void button6_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("6");
            textPanelChange();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("7");
            textPanelChange();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("8");
            textPanelChange();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("9");
            textPanelChange();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            containerOfNumbers.Add("0");
            textPanelChange();
        }
        private void operatorCalculate(string operCalc) 
        {
            int result = calculate();
            containerOfNumbers.Clear();
            containerOfNumbers.Add(Convert.ToString(result));

            if (operCalc != "=")
            {
                if (containerOfNumbers.Count != 0 && listOfString.Contains(containerOfNumbers[containerOfNumbers.Count - 1]))
                {
                    containerOfNumbers.RemoveAt(containerOfNumbers.Count - 1);
                }

                containerOfNumbers.Add(operCalc);
            }
            textPanelChange();

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operatorCalculate("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operatorCalculate("+");
        }

        private void textPanelChange()
        {
           textPanel.Text = String.Join("", containerOfNumbers);
            
        }
        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            operatorCalculate("=");
        }


        private int calculate() 
        {
            int results = 0;

            for (int index = 0; index < containerOfNumbers.Count; index++)
            {
                int lastIndex = containerOfNumbers.Count - 1;

                if (containerOfNumbers[index] == "+" && index != lastIndex)
                {
                    results = Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(0, index)))
                    + Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(index + 1, containerOfNumbers.Count - index - 1)));
                    return results;
                }

                if (containerOfNumbers[index] == "-" && index != lastIndex)
                {
                    results = Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(0, index)))
                    - Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(index + 1, containerOfNumbers.Count - index - 1)));
                    return results;
                }

                if (containerOfNumbers[index] == "/")
                {
                    results = Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(0, index)))
                    / Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(index + 1, containerOfNumbers.Count - index - 1)));
                    return results;
                }

                if (containerOfNumbers[index] == "*")
                {
                    results = Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(0, index)))
                    * Convert.ToInt32(string.Join("", containerOfNumbers.GetRange(index + 1, containerOfNumbers.Count - index - 1)));
                    return results;
                }

            }
            if (listOfString.Contains(containerOfNumbers[containerOfNumbers.Count - 1])) 
            {
                results = Convert.ToInt32(string.Join("", containerOfNumbers[0]));
            }
            else if (containerOfNumbers.Count != 0)
            {
                results = Convert.ToInt32(string.Join("", containerOfNumbers));
            }

            return results;
        }
    }


}
