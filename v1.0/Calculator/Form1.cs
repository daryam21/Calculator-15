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
    public partial class calculator_form : Form
    {
        double ResultValue;
        string OperationPerformed;
        bool OpDone = false;
        bool EqualsUsed = false;
        public calculator_form()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((result_txt.Text=="0")||(OpDone==true))
            {
                result_txt.Clear();
            }
            Button button = (Button)sender;
            EqualsUsed = false;
            if (button.Text==".")       //for not allowing multiple occurences of "."
            {
                if(result_txt.Text.Contains("."))
                {
                    return;
                }
                else
                {
                    result_txt.Text += button.Text;
                    OpDone = false;
                    return;
                }
            }

            
            result_txt.Text += button.Text;
            OpDone = false;

        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperationPerformed = button.Text;
            ResultValue = Double.Parse(result_txt.Text);
            operationperformed_l.Text = ResultValue + " " + OperationPerformed;
            OpDone = true;
            
        }

        private void c_b_Click(object sender, EventArgs e)
        {
            result_txt.Text = "0";
            ResultValue = 0;
        }

        private void ce_b_Click(object sender, EventArgs e)
        {
            result_txt.Text = "0";
        }

        #region for X button
        private void x_b_Click(object sender, EventArgs e)
        {
            string str = result_txt.Text;
            int length = str.Length;
            --length;
            str = str.Remove(length, 1);
            result_txt.Text = str;
        }
        #endregion

        private void equals_b_Click(object sender, EventArgs e)
        {
            OpDone = false;

            if (EqualsUsed==false)
            {
                EqualsUsed = true;
                switch (OperationPerformed)
                {
                    case "+":
                        result_txt.Text = (ResultValue + double.Parse(result_txt.Text)).ToString();

                        break;
                    case "-":
                        result_txt.Text = (ResultValue - double.Parse(result_txt.Text)).ToString();
                        break;
                    case "*":
                        result_txt.Text = (ResultValue * double.Parse(result_txt.Text)).ToString();
                        break;
                    case "/":
                        result_txt.Text = (ResultValue / double.Parse(result_txt.Text)).ToString();
                        break;

                    default:
                        break;
                } 
            }
        }
    }
}
