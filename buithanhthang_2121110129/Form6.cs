using System;
using System.Windows.Forms;

namespace buithanhthang_2121110129
{
    public partial class Form6 : Form
    {
        double value = 0;
        string operation = "";
        bool isNew = true;

        double memory = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ("0123456789".Contains(b.Text))
            {
                if (isNew || textBox1.Text == "0")
                    textBox1.Text = b.Text;
                else
                    textBox1.Text += b.Text;

                isNew = false;
                return;
            }

            if (b.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text += ".";
                return;
            }

            if (b.Text == "C")
            {
                textBox1.Text = "0";
                value = 0;
                operation = "";
                return;
            }

            if (b.Text == "CE")
            {
                textBox1.Text = "0";
                return;
            }

            if (b.Text == "←")
            {
                if (textBox1.Text.Length > 1)
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                else
                    textBox1.Text = "0";
                return;
            }

            if (b.Text == "±")
            {
                textBox1.Text = (-double.Parse(textBox1.Text)).ToString();
                return;
            }

            if (b.Text == "√")
            {
                textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                return;
            }

            if (b.Text == "1/x")
            {
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
                return;
            }

            if (b.Text == "%")
            {
                textBox1.Text = (double.Parse(textBox1.Text) / 100).ToString();
                return;
            }

            switch (b.Text)
            {
                case "MC": memory = 0; return;
                case "MR": textBox1.Text = memory.ToString(); return;
                case "MS": memory = double.Parse(textBox1.Text); return;
                case "M+": memory += double.Parse(textBox1.Text); return;
                case "M-": memory -= double.Parse(textBox1.Text); return;
            }

            if ("+-*/".Contains(b.Text))
            {
                value = double.Parse(textBox1.Text);
                operation = b.Text;
                isNew = true;
                return;
            }

            if (b.Text == "=")
            {
                double v2 = double.Parse(textBox1.Text);
                double result = value;

                switch (operation)
                {
                    case "+": result = value + v2; break;
                    case "-": result = value - v2; break;
                    case "*": result = value * v2; break;
                    case "/": result = v2 == 0 ? 0 : value / v2; break;
                }

                textBox1.Text = result.ToString();
                isNew = true;
            }
        }
    }
}
