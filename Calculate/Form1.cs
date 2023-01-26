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
        public Operand num1 = new Operand();
        public Operand num2 = new Operand();
        public string lastOper = "";

        private List<string> listOfOperators = new List<string> { "+", "-", "*", "/" };

        public Calculator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            proseccing((sender as Button).Text);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            proseccing((sender as Button).Text);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            proseccing((sender as Button).Text);
           
        }
        private void buttonShowResult_Click(object sender, EventArgs e)
        {
            proseccing("=");
        }
        private void proseccing(string input)
        {

            if (listOfOperators.Contains(input) 
)
            {
                lastOper = input;
                string blaBla = Convert.ToString(calculate());
                num1.clear();
                num1.update(blaBla);
                num2.clear();
                
            }
            else if (lastOper == "")
            {
                num1.update(input);
            }

            else 
            {
                num2.update(input);
            }
          
            textPanelChange();

        }

        private void textPanelChange()
        {
            textPanel.Text = num1.getRaw() + lastOper + num2.getRaw();
        }



        public double calculate() 
        {

            return num1.getData() + num2.getData();
 
        }
        
    }


}
