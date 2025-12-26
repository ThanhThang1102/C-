namespace buithanhthang_2121110129
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegisterLink = new LinkLabel();
            exitButton = new Button();
            loginButton = new Button();
            passwordBox = new TextBox();
            email = new TextBox();
            password = new Label();
            username = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Admin = new RadioButton();
            Seller = new RadioButton();
            Customer = new RadioButton();
            SellerRegistration = new LinkLabel();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            RegisterLink.LinkColor = Color.FromArgb(225, 64, 102);
            RegisterLink.Location = new Point(495, 405);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(251, 20);
            RegisterLink.TabIndex = 27;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Bạn chưa có tài khoản? Đăng ký";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(23, 32, 32);
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(762, 346);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(95, 38);
            exitButton.TabIndex = 26;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(225, 64, 102);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.Location = new Point(650, 346);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(95, 38);
            loginButton.TabIndex = 25;
            loginButton.Text = "Đăng nhập";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(650, 280);
            passwordBox.Margin = new Padding(3, 4, 3, 4);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(206, 22);
            passwordBox.TabIndex = 24;
            passwordBox.TextAlign = HorizontalAlignment.Center;
            passwordBox.TextChanged += textBox2_TextChanged;
            // 
            // email
            // 
            email.CharacterCasing = CharacterCasing.Lower;
            email.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(650, 197);
            email.Margin = new Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new Size(206, 22);
            email.TabIndex = 23;
            email.TextAlign = HorizontalAlignment.Center;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.FromArgb(23, 32, 32);
            password.Location = new Point(445, 283);
            password.Name = "password";
            password.Size = new Size(97, 24);
            password.TabIndex = 22;
            password.Text = "Mật khẩu:";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.FromArgb(23, 32, 32);
            username.Location = new Point(445, 197);
            username.Name = "username";
            username.Size = new Size(62, 24);
            username.TabIndex = 21;
            username.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 32, 32);
            label1.Location = new Point(464, 53);
            label1.Name = "label1";
            label1.Size = new Size(357, 55);
            label1.TabIndex = 20;
            label1.Text = "Chào bạn!";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(621, 538);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Location = new Point(762, 322);
            Admin.Margin = new Padding(2, 2, 2, 2);
            Admin.Name = "Admin";
            Admin.Size = new Size(61, 19);
            Admin.TabIndex = 28;
            Admin.TabStop = true;
            Admin.Text = "Admin";
            Admin.UseVisualStyleBackColor = true;
            Admin.CheckedChanged += Admin_CheckedChanged;
            // 
            // Seller
            // 
            Seller.AutoSize = true;
            Seller.Location = new Point(695, 322);
            Seller.Margin = new Padding(2, 2, 2, 2);
            Seller.Name = "Seller";
            Seller.Size = new Size(53, 19);
            Seller.TabIndex = 29;
            Seller.TabStop = true;
            Seller.Text = "Seller";
            Seller.UseVisualStyleBackColor = true;
            Seller.CheckedChanged += Seller_CheckedChanged;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Location = new Point(604, 322);
            Customer.Margin = new Padding(2, 2, 2, 2);
            Customer.Name = "Customer";
            Customer.Size = new Size(77, 19);
            Customer.TabIndex = 30;
            Customer.TabStop = true;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = true;
            Customer.CheckedChanged += Customer_CheckedChanged;
            // 
            // SellerRegistration
            // 
            SellerRegistration.AutoSize = true;
            SellerRegistration.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SellerRegistration.LinkColor = Color.FromArgb(225, 64, 102);
            SellerRegistration.Location = new Point(519, 438);
            SellerRegistration.Name = "SellerRegistration";
            SellerRegistration.Size = new Size(204, 20);
            SellerRegistration.TabIndex = 31;
            SellerRegistration.TabStop = true;
            SellerRegistration.Text = "Bạn chưa có tài khoản Sell? Đăng ký";
            SellerRegistration.LinkClicked += linkLabel1_LinkClicked;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(828, 322);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 32;
            radioButton1.TabStop = true;
            radioButton1.Text = "Shipping";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 215, 217);
            ClientSize = new Size(915, 532);
            Controls.Add(radioButton1);
            Controls.Add(SellerRegistration);
            Controls.Add(Customer);
            Controls.Add(Seller);
            Controls.Add(Admin);
            Controls.Add(RegisterLink);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(passwordBox);
            Controls.Add(email);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.RadioButton Seller;
        private System.Windows.Forms.RadioButton Customer;
        private System.Windows.Forms.LinkLabel SellerRegistration;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}