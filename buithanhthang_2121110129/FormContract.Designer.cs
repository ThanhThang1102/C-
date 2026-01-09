namespace buithanhthang_2121110129
{
    partial class FormContract
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
            btnClose = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            label9 = new Label();
            txtContractID = new TextBox();
            label10 = new Label();
            dtPickStart = new DateTimePicker();
            label11 = new Label();
            dtPickEnd = new DateTimePicker();
            cbTypeWork = new ComboBox();
            cbSpells = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            gbContract = new GroupBox();
            txtSalary = new TextBox();
            label1 = new Label();
            pnlMove.SuspendLayout();
            gbContract.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMove
            // 
            pnlMove.BackColor = Color.OrangeRed;
            pnlMove.Controls.Add(lblTabShow);
            pnlMove.Controls.Add(btnMinimize);
            pnlMove.Controls.Add(btnClose);
            pnlMove.Location = new Point(0, 0);
            pnlMove.Name = "pnlMove";
            pnlMove.Size = new Size(705, 40);
            pnlMove.TabIndex = 2;
            pnlMove.MouseDown += pnlMove_MouseDown;
            pnlMove.MouseMove += pnlMove_MouseMove;
            pnlMove.MouseUp += pnlMove_MouseUp;
            // 
            // lblTabShow
            // 
            lblTabShow.AutoSize = true;
            lblTabShow.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTabShow.ForeColor = SystemColors.ButtonHighlight;
            lblTabShow.Location = new Point(12, 7);
            lblTabShow.Name = "lblTabShow";
            lblTabShow.Size = new Size(199, 24);
            lblTabShow.TabIndex = 4;
            lblTabShow.Text = "Thông tin Hợp đồng";
            // 
            // btnMinimize
            // 
            btnMinimize.Image = Properties.Resources.subtract_26px;
            btnMinimize.Location = new Point(580, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(58, 40);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Image = Properties.Resources.Close_26px;
            btnClose.Location = new Point(644, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 40);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(504, 220);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(168, 34);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(504, 179);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 34);
            btnSave.TabIndex = 50;
            btnSave.Text = "Lưu thông tin";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 37);
            label9.Name = "label9";
            label9.Size = new Size(124, 24);
            label9.TabIndex = 51;
            label9.Text = "Mã hợp đồng";
            // 
            // txtContractID
            // 
            txtContractID.Location = new Point(173, 34);
            txtContractID.Name = "txtContractID";
            txtContractID.ReadOnly = true;
            txtContractID.Size = new Size(499, 29);
            txtContractID.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 74);
            label10.Name = "label10";
            label10.Size = new Size(122, 24);
            label10.TabIndex = 51;
            label10.Text = "Ngày bắt đầu";
            // 
            // dtPickStart
            // 
            dtPickStart.Format = DateTimePickerFormat.Short;
            dtPickStart.Location = new Point(173, 70);
            dtPickStart.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickStart.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtPickStart.Name = "dtPickStart";
            dtPickStart.Size = new Size(258, 29);
            dtPickStart.TabIndex = 52;
            dtPickStart.Value = new DateTime(2026, 1, 9, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 111);
            label11.Name = "label11";
            label11.Size = new Size(124, 24);
            label11.TabIndex = 53;
            label11.Text = "Ngày kết thúc";
            // 
            // dtPickEnd
            // 
            dtPickEnd.Format = DateTimePickerFormat.Short;
            dtPickEnd.Location = new Point(173, 106);
            dtPickEnd.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickEnd.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtPickEnd.Name = "dtPickEnd";
            dtPickEnd.Size = new Size(258, 29);
            dtPickEnd.TabIndex = 54;
            dtPickEnd.Value = new DateTime(2026, 1, 9, 0, 0, 0, 0);
            // 
            // cbTypeWork
            // 
            cbTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeWork.FormattingEnabled = true;
            cbTypeWork.Location = new Point(173, 142);
            cbTypeWork.Name = "cbTypeWork";
            cbTypeWork.Size = new Size(258, 32);
            cbTypeWork.TabIndex = 55;
            cbTypeWork.SelectedIndexChanged += cbTypeWork_SelectedIndexChanged;
            // 
            // cbSpells
            // 
            cbSpells.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpells.FormattingEnabled = true;
            cbSpells.Location = new Point(173, 181);
            cbSpells.Name = "cbSpells";
            cbSpells.Size = new Size(258, 32);
            cbSpells.TabIndex = 56;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 148);
            label12.Name = "label12";
            label12.Size = new Size(142, 24);
            label12.TabIndex = 51;
            label12.Text = "Dạng công việc";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 185);
            label13.Name = "label13";
            label13.Size = new Size(122, 24);
            label13.TabIndex = 57;
            label13.Text = "Buổi làm việc";
            // 
            // gbContract
            // 
            gbContract.BackColor = Color.PaleGreen;
            gbContract.Controls.Add(txtSalary);
            gbContract.Controls.Add(label1);
            gbContract.Controls.Add(btnCancel);
            gbContract.Controls.Add(btnSave);
            gbContract.Controls.Add(label13);
            gbContract.Controls.Add(label12);
            gbContract.Controls.Add(cbSpells);
            gbContract.Controls.Add(cbTypeWork);
            gbContract.Controls.Add(dtPickEnd);
            gbContract.Controls.Add(label11);
            gbContract.Controls.Add(dtPickStart);
            gbContract.Controls.Add(label10);
            gbContract.Controls.Add(txtContractID);
            gbContract.Controls.Add(label9);
            gbContract.Location = new Point(12, 56);
            gbContract.Name = "gbContract";
            gbContract.Size = new Size(678, 281);
            gbContract.TabIndex = 48;
            gbContract.TabStop = false;
            gbContract.Text = "Chi tiết hợp đồng";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(173, 224);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(258, 29);
            txtSalary.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 227);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 58;
            label1.Text = "Mức lương";
            // 
            // FormContract
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(705, 354);
            Controls.Add(gbContract);
            Controls.Add(pnlMove);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormContract";
            Text = "FormStaff";
            pnlMove.ResumeLayout(false);
            pnlMove.PerformLayout();
            gbContract.ResumeLayout(false);
            gbContract.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtPickStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtPickEnd;
        private System.Windows.Forms.ComboBox cbTypeWork;
        private System.Windows.Forms.ComboBox cbSpells;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbContract;
        private TextBox txtSalary;
        private Label label1;
    }
}