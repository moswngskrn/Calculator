using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v2
{
    public partial class Form1 : Form
    {
        double input1;
        double input2;
        double result = 0;
        bool clear = true;
        bool canCal = false;
        bool eq=false;//กดเท่ากับ
        string sign="+";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (clear)
            {
                input1 = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                clear = false;
                canCal = true;
            }
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;
            input2 = Convert.ToDouble(txtDisplay.Text);
        }



        private void cal()
        {
            if (sign == "+")
            {
                result = input1 + input2;
            }
            else if (sign == "-")
            {
                result = input1 - input2;
            }
            else if (sign == "*")
            {
                result = input1 * input2;
            }
            else if (sign == "/")
            {
                result = input1 / input2;
            }
        }

        private void fac(int n)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                sign = "+";
                input1 = 0;
                input2 = Convert.ToDouble(txtDisplay.Text);
                eq = false;
                canCal = false;
            }
            if (canCal)
            {
                cal();
                canCal = false;
            }
            txtDisplay.Text = result.ToString();
            sign = "+";
            clear = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                sign = "+";
                input1 = 0;
                input2 = Convert.ToDouble(txtDisplay.Text);
                eq = false;
                canCal = false;
            }
            if (canCal)
            {
                cal();
                canCal = false;
            }
            txtDisplay.Text = result.ToString();
            sign = "-";
            clear = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                sign = "+";
                input1 = 0;
                input2 = Convert.ToDouble(txtDisplay.Text);
                eq = false;
                canCal = false;
            }
            if (canCal)
            {
                cal();
                canCal = false;
            }
            txtDisplay.Text = result.ToString();
            sign = "*";
            clear = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (eq)
            {
                sign = "+";
                input1 = 0;
                input2 = Convert.ToDouble(txtDisplay.Text);
                eq = false;
                canCal = false;
            }
            if (canCal)
            {
                cal();
                canCal = false;
            }
            txtDisplay.Text = result.ToString();
            sign = "/";
            clear = true;
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            cal();
            input1 = result;
            txtDisplay.Text = result.ToString();
            eq = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            clear = true;
            sign = "+";
            input1 = 0;
            input2 = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int i = txtDisplay.Text.Length;
            if (i == 1)
            {
                txtDisplay.Text = "0";
                clear = true;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Remove(i - 1);
            }
        }
    }
}
