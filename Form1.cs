using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTask1
{
    public partial class Form1 : Form
    {
        string op = "";
        double val = 0;
        bool isOp = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(textBox1.Text == "0" || isOp)
            {
                if (btn.Text == ".")
                {
                    textBox1.Text += btn.Text;
                    return;
                }
                else
                {
                    textBox1.Clear();
                }
                
            }
            if(btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += btn.Text;
                }
            }
            else
            {
                textBox1.Text += btn.Text;
            }
            isOp = false;

        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = btn.Text;
            val = double.Parse(textBox1.Text);
            isOp = true;

        }

        private void eq_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "/":
                    textBox1.Text = (val / double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (val * double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (val - double.Parse(textBox1.Text)).ToString();
                    break;
                case "+":
                    textBox1.Text = (val + double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            val = 0;
        }
    }
}
