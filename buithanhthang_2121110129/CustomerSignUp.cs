using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129
{
    public partial class CustomerSignUp : Form
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerSignUp_Load(object sender, EventArgs e)
        {

        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {

                // Retrieve user input
                string Email = email.Text.Trim();
                string Password = password.Text.Trim();
                string Fname = fname.Text.Trim();
                string Lname = lname.Text.Trim();
                string Street = street.Text.Trim();
                string City = city.Text.Trim();
                string Province = province.Text.Trim();
                string ZipCode = zipCode.Text.Trim();
                string Payment = payment.Text.Trim();

                // Construct the full address
                string Address = $"{Street}, {City}, {Province}, {ZipCode}";

                // Notify the user of successful registration
                MessageBox.Show("Tài khoản của bạn đã được đăng ký!", "Đăng ký hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the Login form
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Display the error message if something goes wrong
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
