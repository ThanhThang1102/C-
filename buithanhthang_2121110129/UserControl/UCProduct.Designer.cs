namespace buithanhthang_2121110129.UserControl
{
    partial class UCProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            gbDetail = new GroupBox();
            btnLoadSupplier = new Button();
            btnEditProduct = new Button();
            gbSupplier = new GroupBox();
            btnSeeMoreSupplier = new Button();
            btnEditSupplier = new Button();
            gbProductOfSupplier = new GroupBox();
            dgvProductOfSupplier = new DataGridView();
            txtSupplierPhone = new TextBox();
            label12 = new Label();
            txtSupplierEmail = new TextBox();
            label11 = new Label();
            txtSupplierAddress = new TextBox();
            label10 = new Label();
            txtSupplierName = new TextBox();
            label9 = new Label();
            txtSupplierID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtNote = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            txtQuantity = new TextBox();
            label5 = new Label();
            txtUnit = new TextBox();
            label4 = new Label();
            txtTypeProduct = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            picRepresent = new PictureBox();
            gbFilter = new GroupBox();
            dgvProduct = new DataGridView();
            btnAddNew = new Button();
            btnReload = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnClear = new Button();
            label1 = new Label();
            numUDTo = new NumericUpDown();
            numUDFrom = new NumericUpDown();
            cbTypeProduct = new ComboBox();
            txtSupplierFilter = new TextBox();
            txtNameFilter = new TextBox();
            chbTypeProduct = new CheckBox();
            chbSupplier = new CheckBox();
            chbPrice = new CheckBox();
            chbName = new CheckBox();
            pnlMain.SuspendLayout();
            gbDetail.SuspendLayout();
            gbSupplier.SuspendLayout();
            gbProductOfSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductOfSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRepresent).BeginInit();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDFrom).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.MediumSeaGreen;
            pnlMain.Controls.Add(gbDetail);
            pnlMain.Controls.Add(gbFilter);
            pnlMain.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1350, 768);
            pnlMain.TabIndex = 2;
            // 
            // gbDetail
            // 
            gbDetail.BackColor = Color.SpringGreen;
            gbDetail.Controls.Add(btnLoadSupplier);
            gbDetail.Controls.Add(btnEditProduct);
            gbDetail.Controls.Add(gbSupplier);
            gbDetail.Controls.Add(label7);
            gbDetail.Controls.Add(txtNote);
            gbDetail.Controls.Add(txtPrice);
            gbDetail.Controls.Add(label6);
            gbDetail.Controls.Add(txtQuantity);
            gbDetail.Controls.Add(label5);
            gbDetail.Controls.Add(txtUnit);
            gbDetail.Controls.Add(label4);
            gbDetail.Controls.Add(txtTypeProduct);
            gbDetail.Controls.Add(label3);
            gbDetail.Controls.Add(txtName);
            gbDetail.Controls.Add(label2);
            gbDetail.Controls.Add(picRepresent);
            gbDetail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDetail.Location = new Point(706, 3);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(641, 719);
            gbDetail.TabIndex = 3;
            gbDetail.TabStop = false;
            gbDetail.Text = "Thông tin sản phẩm và nhà cung cấp";
            // 
            // btnLoadSupplier
            // 
            btnLoadSupplier.Location = new Point(336, 294);
            btnLoadSupplier.Name = "btnLoadSupplier";
            btnLoadSupplier.Size = new Size(299, 36);
            btnLoadSupplier.TabIndex = 38;
            btnLoadSupplier.Text = "Tải thông tin nhà cung cấp";
            btnLoadSupplier.UseVisualStyleBackColor = true;
            btnLoadSupplier.Click += btnLoadSupplier_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(6, 294);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(298, 36);
            btnEditProduct.TabIndex = 32;
            btnEditProduct.Text = "Chỉnh sửa thông tin sản phẩm";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // gbSupplier
            // 
            gbSupplier.BackColor = Color.MediumSpringGreen;
            gbSupplier.Controls.Add(btnSeeMoreSupplier);
            gbSupplier.Controls.Add(btnEditSupplier);
            gbSupplier.Controls.Add(gbProductOfSupplier);
            gbSupplier.Controls.Add(txtSupplierPhone);
            gbSupplier.Controls.Add(label12);
            gbSupplier.Controls.Add(txtSupplierEmail);
            gbSupplier.Controls.Add(label11);
            gbSupplier.Controls.Add(txtSupplierAddress);
            gbSupplier.Controls.Add(label10);
            gbSupplier.Controls.Add(txtSupplierName);
            gbSupplier.Controls.Add(label9);
            gbSupplier.Controls.Add(txtSupplierID);
            gbSupplier.Controls.Add(label8);
            gbSupplier.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSupplier.Location = new Point(6, 336);
            gbSupplier.Name = "gbSupplier";
            gbSupplier.Size = new Size(629, 377);
            gbSupplier.TabIndex = 37;
            gbSupplier.TabStop = false;
            gbSupplier.Text = "Thông tin về nhà cung cấp";
            // 
            // btnSeeMoreSupplier
            // 
            btnSeeMoreSupplier.Location = new Point(324, 339);
            btnSeeMoreSupplier.Name = "btnSeeMoreSupplier";
            btnSeeMoreSupplier.Size = new Size(299, 36);
            btnSeeMoreSupplier.TabIndex = 50;
            btnSeeMoreSupplier.Text = "Xem thêm nhà cung cấp khác";
            btnSeeMoreSupplier.UseVisualStyleBackColor = true;
            btnSeeMoreSupplier.Click += btnSeeMoreSupplier_Click;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.Location = new Point(7, 339);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(299, 36);
            btnEditSupplier.TabIndex = 39;
            btnEditSupplier.Text = "Điều chỉnh thông tin";
            btnEditSupplier.UseVisualStyleBackColor = true;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // gbProductOfSupplier
            // 
            gbProductOfSupplier.Controls.Add(dgvProductOfSupplier);
            gbProductOfSupplier.Location = new Point(7, 189);
            gbProductOfSupplier.Name = "gbProductOfSupplier";
            gbProductOfSupplier.Size = new Size(616, 146);
            gbProductOfSupplier.TabIndex = 49;
            gbProductOfSupplier.TabStop = false;
            gbProductOfSupplier.Text = "Các sản phẩm đang cung cấp";
            // 
            // dgvProductOfSupplier
            // 
            dgvProductOfSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Green;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductOfSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductOfSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductOfSupplier.EnableHeadersVisualStyles = false;
            dgvProductOfSupplier.Location = new Point(6, 26);
            dgvProductOfSupplier.Name = "dgvProductOfSupplier";
            dgvProductOfSupplier.ReadOnly = true;
            dgvProductOfSupplier.Size = new Size(604, 114);
            dgvProductOfSupplier.TabIndex = 0;
            dgvProductOfSupplier.CellClick += dgvProductOfSupplier_CellClick;
            // 
            // txtSupplierPhone
            // 
            txtSupplierPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierPhone.Location = new Point(135, 157);
            txtSupplierPhone.Name = "txtSupplierPhone";
            txtSupplierPhone.ReadOnly = true;
            txtSupplierPhone.Size = new Size(290, 26);
            txtSupplierPhone.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 160);
            label12.Name = "label12";
            label12.Size = new Size(85, 16);
            label12.TabIndex = 47;
            label12.Text = "Số điện thoại";
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierEmail.Location = new Point(136, 123);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.ReadOnly = true;
            txtSupplierEmail.Size = new Size(481, 26);
            txtSupplierEmail.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 126);
            label11.Name = "label11";
            label11.Size = new Size(41, 16);
            label11.TabIndex = 45;
            label11.Text = "Email";
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierAddress.Location = new Point(135, 88);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.ReadOnly = true;
            txtSupplierAddress.Size = new Size(481, 26);
            txtSupplierAddress.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 91);
            label10.Name = "label10";
            label10.Size = new Size(72, 16);
            label10.TabIndex = 43;
            label10.Text = "Địa chỉ kho";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(136, 54);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(481, 26);
            txtSupplierName.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 57);
            label9.Name = "label9";
            label9.Size = new Size(82, 16);
            label9.TabIndex = 41;
            label9.Text = "Tên đại diện";
            // 
            // txtSupplierID
            // 
            txtSupplierID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierID.Location = new Point(136, 22);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.ReadOnly = true;
            txtSupplierID.Size = new Size(290, 26);
            txtSupplierID.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 25);
            label8.Name = "label8";
            label8.Size = new Size(87, 16);
            label8.TabIndex = 39;
            label8.Text = "Mã định danh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(563, 270);
            label7.Name = "label7";
            label7.Size = new Size(51, 16);
            label7.TabIndex = 36;
            label7.Text = "Ghi chú";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(6, 217);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ReadOnly = true;
            txtNote.Size = new Size(629, 70);
            txtNote.TabIndex = 35;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(326, 171);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(311, 22);
            txtPrice.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 173);
            label6.Name = "label6";
            label6.Size = new Size(81, 16);
            label6.TabIndex = 33;
            label6.Text = "Giá niêm yết";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(326, 137);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(311, 22);
            txtQuantity.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 140);
            label5.Name = "label5";
            label5.Size = new Size(85, 16);
            label5.TabIndex = 31;
            label5.Text = "Số lượng kho";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(326, 104);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(311, 22);
            txtUnit.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 107);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 29;
            label4.Text = "Đơn vị";
            // 
            // txtTypeProduct
            // 
            txtTypeProduct.Location = new Point(326, 72);
            txtTypeProduct.Name = "txtTypeProduct";
            txtTypeProduct.ReadOnly = true;
            txtTypeProduct.Size = new Size(311, 22);
            txtTypeProduct.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 75);
            label3.Name = "label3";
            label3.Size = new Size(95, 16);
            label3.TabIndex = 27;
            label3.Text = "Loại sản phẩm";
            // 
            // txtName
            // 
            txtName.Location = new Point(325, 16);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(311, 51);
            txtName.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 19);
            label2.Name = "label2";
            label2.Size = new Size(93, 16);
            label2.TabIndex = 25;
            label2.Text = "Tên sản phẩm";
            // 
            // picRepresent
            // 
            picRepresent.BackColor = Color.Linen;
            picRepresent.BackgroundImageLayout = ImageLayout.Stretch;
            picRepresent.Location = new Point(6, 26);
            picRepresent.Name = "picRepresent";
            picRepresent.Size = new Size(180, 180);
            picRepresent.SizeMode = PictureBoxSizeMode.StretchImage;
            picRepresent.TabIndex = 1;
            picRepresent.TabStop = false;
            // 
            // gbFilter
            // 
            gbFilter.BackColor = Color.SpringGreen;
            gbFilter.Controls.Add(dgvProduct);
            gbFilter.Controls.Add(btnAddNew);
            gbFilter.Controls.Add(btnReload);
            gbFilter.Controls.Add(btnDelete);
            gbFilter.Controls.Add(btnFind);
            gbFilter.Controls.Add(btnClear);
            gbFilter.Controls.Add(label1);
            gbFilter.Controls.Add(numUDTo);
            gbFilter.Controls.Add(numUDFrom);
            gbFilter.Controls.Add(cbTypeProduct);
            gbFilter.Controls.Add(txtSupplierFilter);
            gbFilter.Controls.Add(txtNameFilter);
            gbFilter.Controls.Add(chbTypeProduct);
            gbFilter.Controls.Add(chbSupplier);
            gbFilter.Controls.Add(chbPrice);
            gbFilter.Controls.Add(chbName);
            gbFilter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilter.Location = new Point(3, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(697, 719);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Lọc thông tin";
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Green;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(15, 177);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.Size = new Size(661, 494);
            dgvProduct.TabIndex = 31;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(15, 677);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(183, 36);
            btnAddNew.TabIndex = 30;
            btnAddNew.Text = "Thêm mới";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(15, 135);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(183, 36);
            btnReload.TabIndex = 29;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(493, 677);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 36);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Xóa thông tin";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(493, 135);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(183, 36);
            btnFind.TabIndex = 27;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(304, 135);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(183, 36);
            btnClear.TabIndex = 26;
            btnClear.Text = "Làm trống";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 51);
            label1.Name = "label1";
            label1.Size = new Size(31, 16);
            label1.TabIndex = 25;
            label1.Text = "Đến";
            // 
            // numUDTo
            // 
            numUDTo.Location = new Point(403, 48);
            numUDTo.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numUDTo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDTo.Name = "numUDTo";
            numUDTo.Size = new Size(107, 22);
            numUDTo.TabIndex = 24;
            numUDTo.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numUDFrom
            // 
            numUDFrom.Location = new Point(201, 48);
            numUDFrom.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUDFrom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDFrom.Name = "numUDFrom";
            numUDFrom.Size = new Size(107, 22);
            numUDFrom.TabIndex = 23;
            numUDFrom.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbTypeProduct
            // 
            cbTypeProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeProduct.FormattingEnabled = true;
            cbTypeProduct.Location = new Point(201, 106);
            cbTypeProduct.Name = "cbTypeProduct";
            cbTypeProduct.Size = new Size(475, 24);
            cbTypeProduct.TabIndex = 22;
            // 
            // txtSupplierFilter
            // 
            txtSupplierFilter.Location = new Point(201, 77);
            txtSupplierFilter.Name = "txtSupplierFilter";
            txtSupplierFilter.Size = new Size(475, 22);
            txtSupplierFilter.TabIndex = 21;
            // 
            // txtNameFilter
            // 
            txtNameFilter.Location = new Point(201, 20);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new Size(475, 22);
            txtNameFilter.TabIndex = 20;
            // 
            // chbTypeProduct
            // 
            chbTypeProduct.AutoSize = true;
            chbTypeProduct.Checked = true;
            chbTypeProduct.CheckState = CheckState.Checked;
            chbTypeProduct.Location = new Point(15, 108);
            chbTypeProduct.Name = "chbTypeProduct";
            chbTypeProduct.Size = new Size(114, 20);
            chbTypeProduct.TabIndex = 19;
            chbTypeProduct.Text = "Loại sản phẩm";
            chbTypeProduct.UseVisualStyleBackColor = true;
            chbTypeProduct.CheckedChanged += chbTypeProduct_CheckedChanged;
            // 
            // chbSupplier
            // 
            chbSupplier.AutoSize = true;
            chbSupplier.Checked = true;
            chbSupplier.CheckState = CheckState.Checked;
            chbSupplier.Location = new Point(15, 79);
            chbSupplier.Name = "chbSupplier";
            chbSupplier.Size = new Size(103, 20);
            chbSupplier.TabIndex = 18;
            chbSupplier.Text = "Nhà sản xuất";
            chbSupplier.UseVisualStyleBackColor = true;
            chbSupplier.CheckedChanged += chbSupplier_CheckedChanged;
            // 
            // chbPrice
            // 
            chbPrice.AutoSize = true;
            chbPrice.Checked = true;
            chbPrice.CheckState = CheckState.Checked;
            chbPrice.Location = new Point(15, 50);
            chbPrice.Name = "chbPrice";
            chbPrice.Size = new Size(90, 20);
            chbPrice.TabIndex = 17;
            chbPrice.Text = "Giá (nghìn)";
            chbPrice.UseVisualStyleBackColor = true;
            chbPrice.CheckedChanged += chbPrice_CheckedChanged;
            // 
            // chbName
            // 
            chbName.AutoSize = true;
            chbName.Checked = true;
            chbName.CheckState = CheckState.Checked;
            chbName.Location = new Point(15, 22);
            chbName.Name = "chbName";
            chbName.Size = new Size(112, 20);
            chbName.TabIndex = 16;
            chbName.Text = "Tên sản phẩm";
            chbName.UseVisualStyleBackColor = true;
            chbName.CheckedChanged += chbName_CheckedChanged;
            // 
            // UCProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "UCProduct";
            Size = new Size(1350, 768);
            pnlMain.ResumeLayout(false);
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            gbSupplier.ResumeLayout(false);
            gbSupplier.PerformLayout();
            gbProductOfSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductOfSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRepresent).EndInit();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDFrom).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDTo;
        private System.Windows.Forms.NumericUpDown numUDFrom;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.TextBox txtSupplierFilter;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.CheckBox chbTypeProduct;
        private System.Windows.Forms.CheckBox chbSupplier;
        private System.Windows.Forms.CheckBox chbPrice;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picRepresent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTypeProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadSupplier;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.GroupBox gbSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSeeMoreSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.GroupBox gbProductOfSupplier;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProductOfSupplier;
    }
}
