namespace buithanhthang_2121110129
{
    partial class FormLogin
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
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chbRemember = new CheckBox();
            btnSupport = new Button();
            btnLogin = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(115, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.Location = new Point(88, 103);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tài khoản:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.Location = new Point(88, 159);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(166, 98);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(272, 29);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(166, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(272, 29);
            txtPassword.TabIndex = 4;
            // 
            // chbRemember
            // 
            chbRemember.AutoSize = true;
            chbRemember.Font = new Font("Segoe UI", 10F);
            chbRemember.Location = new Point(166, 197);
            chbRemember.Name = "chbRemember";
            chbRemember.Size = new Size(147, 23);
            chbRemember.TabIndex = 5;
            chbRemember.Text = "Ghi nhớ đăng nhập";
            chbRemember.UseVisualStyleBackColor = true;
            // 
            // btnSupport
            // 
            btnSupport.BackColor = Color.FromArgb(220, 53, 69);
            btnSupport.FlatAppearance.BorderSize = 0;
            btnSupport.FlatStyle = FlatStyle.Flat;
            btnSupport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSupport.ForeColor = Color.White;
            btnSupport.Location = new Point(166, 244);
            btnSupport.Name = "btnSupport";
            btnSupport.Size = new Size(122, 38);
            btnSupport.TabIndex = 6;
            btnSupport.Text = "Hỗ trợ";
            btnSupport.UseVisualStyleBackColor = false;
            btnSupport.Click += BtnSupport_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(315, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 38);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(12, 98);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(70, 75);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(525, 328);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnLogin);
            Controls.Add(btnSupport);
            Controls.Add(chbRemember);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnSupport_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chbRemember;
        private Button btnSupport;
        private Button btnLogin;
        private PictureBox pictureBoxLogo;
    }
}