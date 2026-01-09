namespace buithanhthang_2121110129.UserControl
{
    partial class UCStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);
            cbDateContract = new ComboBox();
            pnlMain = new Panel();
            gbDetail = new GroupBox();
            btnDeleteContract = new Button();
            btnEditContract = new Button();
            txtGender = new TextBox();
            btnMakeContract = new Button();
            gbContractsAndAccount = new GroupBox();
            dgvContracts = new DataGridView();
            btnLoadStaffInfor = new Button();
            label11 = new Label();
            btnEditStaffInfor = new Button();
            btnShowPassword = new Button();
            btnChangePassword = new Button();
            label10 = new Label();
            label9 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            dtPickDoB = new DateTimePicker();
            txtPhone = new MaskedTextBox();
            txtCitizenID = new MaskedTextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            picRepresent = new PictureBox();
            gbFilter = new GroupBox();
            dgvStaff = new DataGridView();
            btnAddNew = new Button();
            btnReload = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnClear = new Button();
            label1 = new Label();
            numUDTo = new NumericUpDown();
            numUDFrom = new NumericUpDown();
            cbSpells = new ComboBox();
            cbTypeWork = new ComboBox();
            cbGenderFilter = new ComboBox();
            txtAddressFilter = new TextBox();
            txtNameFilter = new TextBox();
            chbSpells = new CheckBox();
            chbTypeWork = new CheckBox();
            chbDateContract = new CheckBox();
            chbGender = new CheckBox();
            chbAddress = new CheckBox();
            chbAge = new CheckBox();
            chbName = new CheckBox();
            pnlMain.SuspendLayout();
            gbDetail.SuspendLayout();
            gbContractsAndAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRepresent).BeginInit();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDFrom).BeginInit();
            SuspendLayout();
            // 
            // cbDateContract
            // 
            cbDateContract.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDateContract.FormattingEnabled = true;
            cbDateContract.Location = new Point(205, 138);
            cbDateContract.Name = "cbDateContract";
            cbDateContract.Size = new Size(306, 24);
            cbDateContract.TabIndex = 16;
            toolTip.SetToolTip(cbDateContract, "Unexpired: Còn hạn\r\nExpiration soon: Sắp hết hạn\r\nExpired: Hết hạn\r\n");
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Peru;
            pnlMain.Controls.Add(gbDetail);
            pnlMain.Controls.Add(gbFilter);
            pnlMain.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1366, 733);
            pnlMain.TabIndex = 1;
            // 
            // gbDetail
            // 
            gbDetail.BackColor = Color.LightSalmon;
            gbDetail.Controls.Add(btnDeleteContract);
            gbDetail.Controls.Add(btnEditContract);
            gbDetail.Controls.Add(txtGender);
            gbDetail.Controls.Add(btnMakeContract);
            gbDetail.Controls.Add(gbContractsAndAccount);
            gbDetail.Controls.Add(dtPickDoB);
            gbDetail.Controls.Add(txtPhone);
            gbDetail.Controls.Add(txtCitizenID);
            gbDetail.Controls.Add(txtEmail);
            gbDetail.Controls.Add(txtAddress);
            gbDetail.Controls.Add(txtName);
            gbDetail.Controls.Add(label8);
            gbDetail.Controls.Add(label5);
            gbDetail.Controls.Add(label6);
            gbDetail.Controls.Add(label7);
            gbDetail.Controls.Add(label4);
            gbDetail.Controls.Add(label3);
            gbDetail.Controls.Add(label2);
            gbDetail.Controls.Add(picRepresent);
            gbDetail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDetail.Location = new Point(706, 3);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(657, 727);
            gbDetail.TabIndex = 1;
            gbDetail.TabStop = false;
            gbDetail.Text = "Thông tin nhân viên và hợp đồng";
            // 
            // btnDeleteContract
            // 
            btnDeleteContract.Location = new Point(12, 685);
            btnDeleteContract.Name = "btnDeleteContract";
            btnDeleteContract.Size = new Size(170, 36);
            btnDeleteContract.TabIndex = 35;
            btnDeleteContract.Text = "Xóa hợp đồng";
            btnDeleteContract.UseVisualStyleBackColor = true;
            btnDeleteContract.Click += btnDeleteContract_Click;
            // 
            // btnEditContract
            // 
            btnEditContract.Location = new Point(241, 685);
            btnEditContract.Name = "btnEditContract";
            btnEditContract.Size = new Size(170, 36);
            btnEditContract.TabIndex = 34;
            btnEditContract.Text = "Sửa hợp đồng";
            btnEditContract.UseVisualStyleBackColor = true;
            btnEditContract.Click += btnEditContract_Click;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(297, 49);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(187, 22);
            txtGender.TabIndex = 33;
            // 
            // btnMakeContract
            // 
            btnMakeContract.Location = new Point(475, 685);
            btnMakeContract.Name = "btnMakeContract";
            btnMakeContract.Size = new Size(170, 36);
            btnMakeContract.TabIndex = 24;
            btnMakeContract.Text = "Tạo hợp đồng";
            btnMakeContract.UseVisualStyleBackColor = true;
            btnMakeContract.Click += btnMakeContract_Click;
            // 
            // gbContractsAndAccount
            // 
            gbContractsAndAccount.BackColor = Color.Salmon;
            gbContractsAndAccount.Controls.Add(dgvContracts);
            gbContractsAndAccount.Controls.Add(btnLoadStaffInfor);
            gbContractsAndAccount.Controls.Add(label11);
            gbContractsAndAccount.Controls.Add(btnEditStaffInfor);
            gbContractsAndAccount.Controls.Add(btnShowPassword);
            gbContractsAndAccount.Controls.Add(btnChangePassword);
            gbContractsAndAccount.Controls.Add(label10);
            gbContractsAndAccount.Controls.Add(label9);
            gbContractsAndAccount.Controls.Add(txtPassword);
            gbContractsAndAccount.Controls.Add(txtUsername);
            gbContractsAndAccount.Location = new Point(6, 253);
            gbContractsAndAccount.Name = "gbContractsAndAccount";
            gbContractsAndAccount.Size = new Size(645, 426);
            gbContractsAndAccount.TabIndex = 30;
            gbContractsAndAccount.TabStop = false;
            gbContractsAndAccount.Text = "Thông tin hợp đồng và tài khoản";
            // 
            // dgvContracts
            // 
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Location = new Point(6, 152);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.Size = new Size(633, 268);
            dgvContracts.TabIndex = 37;
            // 
            // btnLoadStaffInfor
            // 
            btnLoadStaffInfor.Location = new Point(184, 85);
            btnLoadStaffInfor.Name = "btnLoadStaffInfor";
            btnLoadStaffInfor.Size = new Size(114, 33);
            btnLoadStaffInfor.TabIndex = 32;
            btnLoadStaffInfor.Text = "Tải thông tin";
            btnLoadStaffInfor.UseVisualStyleBackColor = true;
            btnLoadStaffInfor.Click += btnLoadStaffInfor_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 123);
            label11.Name = "label11";
            label11.Size = new Size(281, 20);
            label11.TabIndex = 36;
            label11.Text = "Danh sách hợp đồng với cửa hàng";
            // 
            // btnEditStaffInfor
            // 
            btnEditStaffInfor.Location = new Point(6, 85);
            btnEditStaffInfor.Name = "btnEditStaffInfor";
            btnEditStaffInfor.Size = new Size(172, 33);
            btnEditStaffInfor.TabIndex = 31;
            btnEditStaffInfor.Text = "Sửa thông tin nhân viên";
            btnEditStaffInfor.UseVisualStyleBackColor = true;
            btnEditStaffInfor.Click += btnEditStaffInfor_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Location = new Point(304, 85);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(151, 33);
            btnShowPassword.TabIndex = 35;
            btnShowPassword.Text = "Hiện mật khẩu";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(459, 85);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(164, 33);
            btnChangePassword.TabIndex = 32;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 56);
            label10.Name = "label10";
            label10.Size = new Size(61, 16);
            label10.TabIndex = 34;
            label10.Text = "Mật khẩu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 24);
            label9.Name = "label9";
            label9.Size = new Size(67, 16);
            label9.TabIndex = 32;
            label9.Text = "Tài khoản";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(179, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(444, 22);
            txtPassword.TabIndex = 33;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(179, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(444, 22);
            txtUsername.TabIndex = 32;
            // 
            // dtPickDoB
            // 
            dtPickDoB.Enabled = false;
            dtPickDoB.Format = DateTimePickerFormat.Short;
            dtPickDoB.Location = new Point(297, 82);
            dtPickDoB.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickDoB.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtPickDoB.Name = "dtPickDoB";
            dtPickDoB.Size = new Size(186, 22);
            dtPickDoB.TabIndex = 29;
            dtPickDoB.Value = new DateTime(2026, 1, 9, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(297, 182);
            txtPhone.Mask = "0000-000-000";
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(187, 22);
            txtPhone.TabIndex = 28;
            // 
            // txtCitizenID
            // 
            txtCitizenID.Location = new Point(297, 115);
            txtCitizenID.Mask = "000000000000";
            txtCitizenID.Name = "txtCitizenID";
            txtCitizenID.ReadOnly = true;
            txtCitizenID.Size = new Size(187, 22);
            txtCitizenID.TabIndex = 27;
            txtCitizenID.ValidatingType = typeof(int);
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(297, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(338, 22);
            txtEmail.TabIndex = 26;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(297, 148);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(338, 22);
            txtAddress.TabIndex = 25;
            // 
            // txtName
            // 
            txtName.Location = new Point(297, 18);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(338, 22);
            txtName.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 219);
            label8.Name = "label8";
            label8.Size = new Size(41, 16);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 185);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 6;
            label5.Text = "Điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 151);
            label6.Name = "label6";
            label6.Size = new Size(47, 16);
            label6.TabIndex = 5;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(180, 118);
            label7.Name = "label7";
            label7.Size = new Size(44, 16);
            label7.TabIndex = 4;
            label7.Text = "CCCD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 86);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 52);
            label3.Name = "label3";
            label3.Size = new Size(31, 16);
            label3.TabIndex = 2;
            label3.Text = "Giới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 22);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // picRepresent
            // 
            picRepresent.BackColor = Color.Linen;
            picRepresent.Location = new Point(6, 22);
            picRepresent.Name = "picRepresent";
            picRepresent.Size = new Size(168, 224);
            picRepresent.SizeMode = PictureBoxSizeMode.StretchImage;
            picRepresent.TabIndex = 0;
            picRepresent.TabStop = false;
            // 
            // gbFilter
            // 
            gbFilter.BackColor = Color.LightSalmon;
            gbFilter.Controls.Add(dgvStaff);
            gbFilter.Controls.Add(btnAddNew);
            gbFilter.Controls.Add(btnReload);
            gbFilter.Controls.Add(btnDelete);
            gbFilter.Controls.Add(btnFind);
            gbFilter.Controls.Add(btnClear);
            gbFilter.Controls.Add(cbDateContract);
            gbFilter.Controls.Add(label1);
            gbFilter.Controls.Add(numUDTo);
            gbFilter.Controls.Add(numUDFrom);
            gbFilter.Controls.Add(cbSpells);
            gbFilter.Controls.Add(cbTypeWork);
            gbFilter.Controls.Add(cbGenderFilter);
            gbFilter.Controls.Add(txtAddressFilter);
            gbFilter.Controls.Add(txtNameFilter);
            gbFilter.Controls.Add(chbSpells);
            gbFilter.Controls.Add(chbTypeWork);
            gbFilter.Controls.Add(chbDateContract);
            gbFilter.Controls.Add(chbGender);
            gbFilter.Controls.Add(chbAddress);
            gbFilter.Controls.Add(chbAge);
            gbFilter.Controls.Add(chbName);
            gbFilter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(3, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(697, 727);
            gbFilter.TabIndex = 0;
            gbFilter.TabStop = false;
            gbFilter.Text = "Lọc thông tin";
            // 
            // dgvStaff
            // 
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(19, 275);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.Size = new Size(661, 404);
            dgvStaff.TabIndex = 23;
            dgvStaff.CellClick += dgvStaff_CellClick;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(19, 685);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(183, 36);
            btnAddNew.TabIndex = 21;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(19, 233);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(183, 37);
            btnReload.TabIndex = 20;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(497, 685);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 36);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Xóa thông tin";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(497, 233);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(183, 36);
            btnFind.TabIndex = 18;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(308, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(183, 36);
            btnClear.TabIndex = 17;
            btnClear.Text = "Làm trống";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 50);
            label1.Name = "label1";
            label1.Size = new Size(31, 16);
            label1.TabIndex = 15;
            label1.Text = "Đến";
            // 
            // numUDTo
            // 
            numUDTo.Location = new Point(404, 48);
            numUDTo.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
            numUDTo.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numUDTo.Name = "numUDTo";
            numUDTo.Size = new Size(107, 22);
            numUDTo.TabIndex = 14;
            numUDTo.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // numUDFrom
            // 
            numUDFrom.Location = new Point(205, 48);
            numUDFrom.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
            numUDFrom.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numUDFrom.Name = "numUDFrom";
            numUDFrom.Size = new Size(107, 22);
            numUDFrom.TabIndex = 13;
            numUDFrom.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // cbSpells
            // 
            cbSpells.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpells.FormattingEnabled = true;
            cbSpells.Location = new Point(205, 201);
            cbSpells.Name = "cbSpells";
            cbSpells.Size = new Size(306, 24);
            cbSpells.TabIndex = 12;
            // 
            // cbTypeWork
            // 
            cbTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeWork.FormattingEnabled = true;
            cbTypeWork.Location = new Point(205, 170);
            cbTypeWork.Name = "cbTypeWork";
            cbTypeWork.Size = new Size(306, 24);
            cbTypeWork.TabIndex = 11;
            cbTypeWork.SelectedIndexChanged += cbTypeWork_SelectedIndexChanged;
            // 
            // cbGenderFilter
            // 
            cbGenderFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenderFilter.FormattingEnabled = true;
            cbGenderFilter.Items.AddRange(new object[] { "nam", "nữ", "khác" });
            cbGenderFilter.Location = new Point(205, 107);
            cbGenderFilter.Name = "cbGenderFilter";
            cbGenderFilter.Size = new Size(176, 24);
            cbGenderFilter.TabIndex = 10;
            // 
            // txtAddressFilter
            // 
            txtAddressFilter.Location = new Point(205, 78);
            txtAddressFilter.Name = "txtAddressFilter";
            txtAddressFilter.Size = new Size(475, 22);
            txtAddressFilter.TabIndex = 9;
            // 
            // txtNameFilter
            // 
            txtNameFilter.Location = new Point(205, 20);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new Size(475, 22);
            txtNameFilter.TabIndex = 8;
            // 
            // chbSpells
            // 
            chbSpells.AutoSize = true;
            chbSpells.Checked = true;
            chbSpells.CheckState = CheckState.Checked;
            chbSpells.Location = new Point(19, 206);
            chbSpells.Name = "chbSpells";
            chbSpells.Size = new Size(106, 20);
            chbSpells.TabIndex = 7;
            chbSpells.Text = "Buổi làm việc";
            chbSpells.UseVisualStyleBackColor = true;
            chbSpells.CheckedChanged += chbSpells_CheckedChanged;
            // 
            // chbTypeWork
            // 
            chbTypeWork.AutoSize = true;
            chbTypeWork.Checked = true;
            chbTypeWork.CheckState = CheckState.Checked;
            chbTypeWork.Location = new Point(19, 176);
            chbTypeWork.Name = "chbTypeWork";
            chbTypeWork.Size = new Size(120, 20);
            chbTypeWork.TabIndex = 5;
            chbTypeWork.Text = "Dạng công việc";
            chbTypeWork.UseVisualStyleBackColor = true;
            chbTypeWork.CheckedChanged += chbTypeWork_CheckedChanged;
            // 
            // chbDateContract
            // 
            chbDateContract.AutoSize = true;
            chbDateContract.Checked = true;
            chbDateContract.CheckState = CheckState.Checked;
            chbDateContract.Location = new Point(19, 145);
            chbDateContract.Name = "chbDateContract";
            chbDateContract.Size = new Size(111, 20);
            chbDateContract.TabIndex = 4;
            chbDateContract.Text = "Hạn hợp đồng";
            chbDateContract.UseVisualStyleBackColor = true;
            chbDateContract.CheckedChanged += chbDateContract_CheckedChanged;
            // 
            // chbGender
            // 
            chbGender.AutoSize = true;
            chbGender.Checked = true;
            chbGender.CheckState = CheckState.Checked;
            chbGender.Location = new Point(19, 115);
            chbGender.Name = "chbGender";
            chbGender.Size = new Size(73, 20);
            chbGender.TabIndex = 3;
            chbGender.Text = "Giới tính";
            chbGender.UseVisualStyleBackColor = true;
            chbGender.CheckedChanged += chbGender_CheckedChanged;
            // 
            // chbAddress
            // 
            chbAddress.AutoSize = true;
            chbAddress.Checked = true;
            chbAddress.CheckState = CheckState.Checked;
            chbAddress.Location = new Point(19, 84);
            chbAddress.Name = "chbAddress";
            chbAddress.Size = new Size(66, 20);
            chbAddress.TabIndex = 2;
            chbAddress.Text = "Địa chỉ";
            chbAddress.UseVisualStyleBackColor = true;
            chbAddress.CheckedChanged += chbAddress_CheckedChanged;
            // 
            // chbAge
            // 
            chbAge.AutoSize = true;
            chbAge.Checked = true;
            chbAge.CheckState = CheckState.Checked;
            chbAge.Location = new Point(19, 52);
            chbAge.Name = "chbAge";
            chbAge.Size = new Size(67, 20);
            chbAge.TabIndex = 1;
            chbAge.Text = "Độ tuổi";
            chbAge.UseVisualStyleBackColor = true;
            chbAge.CheckedChanged += chbAge_CheckedChanged;
            // 
            // chbName
            // 
            chbName.AutoSize = true;
            chbName.Checked = true;
            chbName.CheckState = CheckState.Checked;
            chbName.Location = new Point(19, 22);
            chbName.Name = "chbName";
            chbName.Size = new Size(110, 20);
            chbName.TabIndex = 0;
            chbName.Text = "Tên nhân viên";
            chbName.UseVisualStyleBackColor = true;
            chbName.CheckedChanged += chbName_CheckedChanged;
            // 
            // UCStaff
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "UCStaff";
            Size = new Size(1366, 733);
            pnlMain.ResumeLayout(false);
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            gbContractsAndAccount.ResumeLayout(false);
            gbContractsAndAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRepresent).EndInit();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDFrom).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbDateContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDTo;
        private System.Windows.Forms.NumericUpDown numUDFrom;
        private System.Windows.Forms.ComboBox cbSpells;
        private System.Windows.Forms.ComboBox cbTypeWork;
        private System.Windows.Forms.ComboBox cbGenderFilter;
        private System.Windows.Forms.TextBox txtAddressFilter;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.CheckBox chbSpells;
        private System.Windows.Forms.CheckBox chbTypeWork;
        private System.Windows.Forms.CheckBox chbDateContract;
        private System.Windows.Forms.CheckBox chbGender;
        private System.Windows.Forms.CheckBox chbAddress;
        private System.Windows.Forms.CheckBox chbAge;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.PictureBox picRepresent;
        private System.Windows.Forms.DateTimePicker dtPickDoB;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtCitizenID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditStaffInfor;
        private System.Windows.Forms.Button btnMakeContract;
        private System.Windows.Forms.GroupBox gbContractsAndAccount;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLoadStaffInfor;
        private System.Windows.Forms.TextBox txtGender;
        private Button btnEditContract;
        private Button btnDeleteContract;
    }
}
