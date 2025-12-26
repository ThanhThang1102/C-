using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!Admin.Checked && !Customer.Checked && !Seller.Checked && !radioButton1.Checked)
            {
                MessageBox.Show("Vui lòng chọn loại người dùng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string Email = email.Text;
            string Password = passwordBox.Text;
            string LoginQuery = "";
            
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seller_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public static class Session
    {
        public static int UserID { get; set; }
    }
}
