using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double so1 = 0;
        string pheptoan = "";

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                so1 = double.Parse(textBox1.Text);
                pheptoan = "+";
                textBox1.Clear();
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                so1 = double.Parse(textBox1.Text);
                pheptoan = "*";
                textBox1.Clear();
            }
        }

        private void btCham_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }

        private void btKQ_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double so2 = double.Parse(textBox1.Text);
                double kq = 0;

                if (pheptoan == "+")
                    kq = so1 + so2;
                else if (pheptoan == "*")
                    kq = so1 * so2;

                textBox1.Text = kq.ToString();
            }
        }
    }
}
