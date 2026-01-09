namespace buithanhthang_2121110129
{
    partial class FormCustomer
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
            pnlMove = new Panel();
            lblTabShow = new Label();
            btnMinimize = new Button();
            pnlMain = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            dtPickDateJoin = new DateTimePicker();
            txtPhone = new MaskedTextBox();
            txtCustomerValue = new TextBox();
            txtName = new TextBox();
            lblCustomerPhone = new Label();
            lblCustomerValue = new Label();
            lblCustomerDateJoin = new Label();
            lblCustomerName = new Label();
            pnlMove.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMove
            // 
            pnlMove.BackColor = Color.OrangeRed;
            pnlMove.Controls.Add(lblTabShow);
            pnlMove.Controls.Add(btnMinimize);
            pnlMove.Location = new Point(0, 0);
            pnlMove.Margin = new Padding(4, 3, 4, 3);
            pnlMove.Name = "pnlMove";
            pnlMove.Size = new Size(583, 46);
            pnlMove.TabIndex = 3;
            pnlMove.MouseDown += pnlMove_MouseDown;
            pnlMove.MouseMove += pnlMove_MouseMove;
            pnlMove.MouseUp += pnlMove_MouseUp;
            // 
            // lblTabShow
            // 
            lblTabShow.AutoSize = true;
            lblTabShow.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTabShow.ForeColor = SystemColors.ButtonHighlight;
            lblTabShow.Location = new Point(14, 8);
            lblTabShow.Margin = new Padding(4, 0, 4, 0);
            lblTabShow.Name = "lblTabShow";
            lblTabShow.Size = new Size(214, 24);
            lblTabShow.TabIndex = 4;
            lblTabShow.Text = "Thông tin khách hàng";
            // 
            // btnMinimize
            // 
            btnMinimize.Image = Properties.Resources.subtract_26px;
            btnMinimize.Location = new Point(502, 0);
            btnMinimize.Margin = new Padding(4, 3, 4, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(68, 46);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(255, 255, 192);
            pnlMain.Controls.Add(btnCancel);
            pnlMain.Controls.Add(btnSave);
            pnlMain.Controls.Add(dtPickDateJoin);
            pnlMain.Controls.Add(txtPhone);
            pnlMain.Controls.Add(txtCustomerValue);
            pnlMain.Controls.Add(txtName);
            pnlMain.Controls.Add(lblCustomerPhone);
            pnlMain.Controls.Add(lblCustomerValue);
            pnlMain.Controls.Add(lblCustomerDateJoin);
            pnlMain.Controls.Add(lblCustomerName);
            pnlMain.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(0, 46);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(583, 277);
            pnlMain.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(399, 226);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 38);
            btnCancel.TabIndex = 54;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(175, 226);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(217, 38);
            btnSave.TabIndex = 53;
            btnSave.Text = "Lưu thông tin";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtPickDateJoin
            // 
            dtPickDateJoin.Format = DateTimePickerFormat.Short;
            dtPickDateJoin.Location = new Point(175, 68);
            dtPickDateJoin.Margin = new Padding(4, 3, 4, 3);
            dtPickDateJoin.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickDateJoin.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtPickDateJoin.Name = "dtPickDateJoin";
            dtPickDateJoin.Size = new Size(216, 26);
            dtPickDateJoin.TabIndex = 52;
            dtPickDateJoin.Value = new DateTime(2026, 1, 9, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(175, 119);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Mask = "0000-000-000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(218, 26);
            txtPhone.TabIndex = 51;
            // 
            // txtCustomerValue
            // 
            txtCustomerValue.Location = new Point(175, 170);
            txtCustomerValue.Margin = new Padding(4, 3, 4, 3);
            txtCustomerValue.Name = "txtCustomerValue";
            txtCustomerValue.ReadOnly = true;
            txtCustomerValue.Size = new Size(394, 26);
            txtCustomerValue.TabIndex = 50;
            // 
            // txtName
            // 
            txtName.Location = new Point(175, 17);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(394, 26);
            txtName.TabIndex = 49;
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Location = new Point(24, 123);
            lblCustomerPhone.Margin = new Padding(4, 0, 4, 0);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(81, 20);
            lblCustomerPhone.TabIndex = 48;
            lblCustomerPhone.Text = "Điện thoại";
            // 
            // lblCustomerValue
            // 
            lblCustomerValue.AutoSize = true;
            lblCustomerValue.Location = new Point(24, 173);
            lblCustomerValue.Margin = new Padding(4, 0, 4, 0);
            lblCustomerValue.Name = "lblCustomerValue";
            lblCustomerValue.Size = new Size(103, 20);
            lblCustomerValue.TabIndex = 47;
            lblCustomerValue.Text = "Giá trị tích lũy";
            // 
            // lblCustomerDateJoin
            // 
            lblCustomerDateJoin.AutoSize = true;
            lblCustomerDateJoin.Location = new Point(24, 74);
            lblCustomerDateJoin.Margin = new Padding(4, 0, 4, 0);
            lblCustomerDateJoin.Name = "lblCustomerDateJoin";
            lblCustomerDateJoin.Size = new Size(110, 20);
            lblCustomerDateJoin.TabIndex = 46;
            lblCustomerDateJoin.Text = "Ngày tham gia";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(24, 24);
            lblCustomerName.Margin = new Padding(4, 0, 4, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(57, 20);
            lblCustomerName.TabIndex = 45;
            lblCustomerName.Text = "Họ tên";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 323);
            Controls.Add(pnlMain);
            Controls.Add(pnlMove);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCustomer";
            Text = "FormCustomer";
            pnlMove.ResumeLayout(false);
            pnlMove.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DateTimePicker dtPickDateJoin;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtCustomerValue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerValue;
        private System.Windows.Forms.Label lblCustomerDateJoin;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}