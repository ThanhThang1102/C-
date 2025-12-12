using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbX.Text);
            int y = int.Parse(tbY.Text);
            int kq = x + y;
            tbKQ.Text = tbKQ.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {

            int x = int.Parse(tbX.Text);
            int y = int.Parse(tbY.Text);
            int kq = x * y;
            tbKQ.Text = tbKQ.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter s = new StreamWriter("ketqua.txt", true);
            s.Write(tbKQ.Text);
            s.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
