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
    public partial class calculator : Form
    {
        int num;
        int num2;
        char oper;
        public calculator()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn7.Text;
            else
                txtInput.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn8.Text;
            else
                txtInput.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn9.Text;
            else
                txtInput.Text += btn9.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn6.Text;
            else
                txtInput.Text += btn6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn5.Text;
            else
                txtInput.Text += btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn4.Text;
            else
                txtInput.Text += btn4.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn3.Text;
            else
                txtInput.Text += btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn2.Text;
            else
                txtInput.Text += btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn1.Text;
            else
                txtInput.Text += btn1.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text == "0") && (txtInput != null))
                txtInput.Text = btn0.Text;
            else
                txtInput.Text += btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtInput.Text);
            oper = '+';
            txtInput.Text = "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtInput.Text);
            oper = '-';
            txtInput.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtInput.Text);
            oper = '/';
            txtInput.Text = "0";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtInput.Text);
            oper = '*';
            txtInput.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtInput.Text);
            switch (oper)
            {
                case '+':
                    num = num + num2;
                    txtInput.Text = Convert.ToString(num); 
                    break;
                case '-':
                    num = num - num2;
                    txtInput.Text = Convert.ToString(num);
                    break;
                case '*':
                    num = num * num2;
                    txtInput.Text = Convert.ToString(num);
                    break;
                case '/':
                    num = num / num2;
                    txtInput.Text = Convert.ToString(num);
                    break;
            }
        }
    }
}
