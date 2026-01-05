namespace buithanhthang_2121110129.UserControl
{
    partial class UCImported
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            gbMakeBill = new GroupBox();
            btnMakeBills = new Button();
            btnCancelBill = new Button();
            gbListProduct = new GroupBox();
            flowpnl_Item = new FlowLayoutPanel();
            dtPickDateCreate = new DateTimePicker();
            txtStaffName = new TextBox();
            txtBillID = new TextBox();
            txtTotalPrice = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbFilter = new GroupBox();
            dgvProduct = new DataGridView();
            btnReload = new Button();
            btnMakeNewProduct = new Button();
            btnCheckSupplier = new Button();
            btnChooseProduct = new Button();
            btnCheckHistory = new Button();
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
            toolTip = new ToolTip(components);
            pnlMain.SuspendLayout();
            gbMakeBill.SuspendLayout();
            gbListProduct.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDFrom).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.DarkViolet;
            pnlMain.Controls.Add(gbMakeBill);
            pnlMain.Controls.Add(gbFilter);
            pnlMain.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1350, 768);
            pnlMain.TabIndex = 3;
            // 
            // gbMakeBill
            // 
            gbMakeBill.BackColor = Color.FromArgb(202, 158, 247);
            gbMakeBill.Controls.Add(btnMakeBills);
            gbMakeBill.Controls.Add(btnCancelBill);
            gbMakeBill.Controls.Add(gbListProduct);
            gbMakeBill.Controls.Add(dtPickDateCreate);
            gbMakeBill.Controls.Add(txtStaffName);
            gbMakeBill.Controls.Add(txtBillID);
            gbMakeBill.Controls.Add(txtTotalPrice);
            gbMakeBill.Controls.Add(label6);
            gbMakeBill.Controls.Add(label4);
            gbMakeBill.Controls.Add(label3);
            gbMakeBill.Controls.Add(label2);
            gbMakeBill.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbMakeBill.Location = new Point(706, 3);
            gbMakeBill.Name = "gbMakeBill";
            gbMakeBill.Size = new Size(641, 726);
            gbMakeBill.TabIndex = 6;
            gbMakeBill.TabStop = false;
            gbMakeBill.Text = "Tạo thông tin nhập hàng";
            // 
            // btnMakeBills
            // 
            btnMakeBills.Location = new Point(452, 681);
            btnMakeBills.Name = "btnMakeBills";
            btnMakeBills.Size = new Size(183, 36);
            btnMakeBills.TabIndex = 38;
            btnMakeBills.Text = "Tạo phiếu nhập";
            btnMakeBills.UseVisualStyleBackColor = true;
            btnMakeBills.Click += btnMakeBills_Click;
            // 
            // btnCancelBill
            // 
            btnCancelBill.Location = new Point(6, 681);
            btnCancelBill.Name = "btnCancelBill";
            btnCancelBill.Size = new Size(183, 36);
            btnCancelBill.TabIndex = 32;
            btnCancelBill.Text = "Hủy phiếu nhập";
            btnCancelBill.UseVisualStyleBackColor = true;
            btnCancelBill.Click += btnCancelBill_Click;
            // 
            // gbListProduct
            // 
            gbListProduct.Controls.Add(flowpnl_Item);
            gbListProduct.Location = new Point(6, 150);
            gbListProduct.Name = "gbListProduct";
            gbListProduct.Size = new Size(629, 525);
            gbListProduct.TabIndex = 37;
            gbListProduct.TabStop = false;
            gbListProduct.Text = "Danh sách sản phẩm nhập kho";
            // 
            // flowpnl_Item
            // 
            flowpnl_Item.AutoScroll = true;
            flowpnl_Item.BackColor = SystemColors.ControlDark;
            flowpnl_Item.ForeColor = SystemColors.ControlText;
            flowpnl_Item.Location = new Point(6, 21);
            flowpnl_Item.Name = "flowpnl_Item";
            flowpnl_Item.Size = new Size(617, 498);
            flowpnl_Item.TabIndex = 1;
            toolTip.SetToolTip(flowpnl_Item, "Nhấn đúp chuột vào sản phẩm để thêm vào giỏ hàng");
            // 
            // dtPickDateCreate
            // 
            dtPickDateCreate.DropDownAlign = LeftRightAlignment.Right;
            dtPickDateCreate.Enabled = false;
            dtPickDateCreate.Format = DateTimePickerFormat.Short;
            dtPickDateCreate.Location = new Point(189, 84);
            dtPickDateCreate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickDateCreate.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtPickDateCreate.Name = "dtPickDateCreate";
            dtPickDateCreate.Size = new Size(351, 22);
            dtPickDateCreate.TabIndex = 36;
            dtPickDateCreate.Value = new DateTime(2022, 2, 4, 0, 0, 0, 0);
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(189, 22);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(446, 22);
            txtStaffName.TabIndex = 35;
            // 
            // txtBillID
            // 
            txtBillID.Location = new Point(189, 53);
            txtBillID.Name = "txtBillID";
            txtBillID.ReadOnly = true;
            txtBillID.Size = new Size(351, 22);
            txtBillID.TabIndex = 34;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(189, 118);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(351, 22);
            txtTotalPrice.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 118);
            label6.Name = "label6";
            label6.Size = new Size(63, 16);
            label6.TabIndex = 3;
            label6.Text = "Tổng tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 86);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 2;
            label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 56);
            label3.Name = "label3";
            label3.Size = new Size(78, 16);
            label3.TabIndex = 1;
            label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 25);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 0;
            label2.Text = "Nhân viên";
            // 
            // gbFilter
            // 
            gbFilter.BackColor = Color.FromArgb(202, 158, 247);
            gbFilter.Controls.Add(dgvProduct);
            gbFilter.Controls.Add(btnReload);
            gbFilter.Controls.Add(btnMakeNewProduct);
            gbFilter.Controls.Add(btnCheckSupplier);
            gbFilter.Controls.Add(btnChooseProduct);
            gbFilter.Controls.Add(btnCheckHistory);
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
            gbFilter.Size = new Size(697, 726);
            gbFilter.TabIndex = 5;
            gbFilter.TabStop = false;
            gbFilter.Text = "Lọc thông tin";
            // 
            // dgvProduct
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumPurple;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(15, 192);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.Size = new Size(661, 441);
            dgvProduct.TabIndex = 34;
            dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(15, 150);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(183, 36);
            btnReload.TabIndex = 33;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnMakeNewProduct
            // 
            btnMakeNewProduct.Location = new Point(17, 639);
            btnMakeNewProduct.Name = "btnMakeNewProduct";
            btnMakeNewProduct.Size = new Size(275, 36);
            btnMakeNewProduct.TabIndex = 32;
            btnMakeNewProduct.Text = "Thêm sản phẩm mới";
            btnMakeNewProduct.UseVisualStyleBackColor = true;
            btnMakeNewProduct.Click += btnMakeNewProduct_Click;
            // 
            // btnCheckSupplier
            // 
            btnCheckSupplier.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckSupplier.Location = new Point(17, 681);
            btnCheckSupplier.Name = "btnCheckSupplier";
            btnCheckSupplier.Size = new Size(275, 36);
            btnCheckSupplier.TabIndex = 30;
            btnCheckSupplier.Text = "Thông tin các nhà cung cấp";
            btnCheckSupplier.UseVisualStyleBackColor = true;
            btnCheckSupplier.Click += btnCheckSupplier_Click;
            // 
            // btnChooseProduct
            // 
            btnChooseProduct.Location = new Point(403, 639);
            btnChooseProduct.Name = "btnChooseProduct";
            btnChooseProduct.Size = new Size(275, 36);
            btnChooseProduct.TabIndex = 29;
            btnChooseProduct.Text = "Chọn sản phẩm";
            btnChooseProduct.UseVisualStyleBackColor = true;
            btnChooseProduct.Click += btnChooseProduct_Click;
            // 
            // btnCheckHistory
            // 
            btnCheckHistory.Location = new Point(403, 681);
            btnCheckHistory.Name = "btnCheckHistory";
            btnCheckHistory.Size = new Size(275, 36);
            btnCheckHistory.TabIndex = 28;
            btnCheckHistory.Text = "Lịch sử nhập hàng";
            btnCheckHistory.UseVisualStyleBackColor = true;
            btnCheckHistory.Click += btnCheckHistory_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(493, 150);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(183, 36);
            btnFind.TabIndex = 27;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(304, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(183, 36);
            btnClear.TabIndex = 26;
            btnClear.Text = "Làm trống";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 57);
            label1.Name = "label1";
            label1.Size = new Size(31, 16);
            label1.TabIndex = 25;
            label1.Text = "Đến";
            // 
            // numUDTo
            // 
            numUDTo.Location = new Point(403, 54);
            numUDTo.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numUDTo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUDTo.Name = "numUDTo";
            numUDTo.Size = new Size(107, 22);
            numUDTo.TabIndex = 24;
            numUDTo.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numUDFrom
            // 
            numUDFrom.Location = new Point(201, 54);
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
            cbTypeProduct.Location = new Point(201, 117);
            cbTypeProduct.Name = "cbTypeProduct";
            cbTypeProduct.Size = new Size(475, 24);
            cbTypeProduct.TabIndex = 22;
            // 
            // txtSupplierFilter
            // 
            txtSupplierFilter.Location = new Point(201, 86);
            txtSupplierFilter.Name = "txtSupplierFilter";
            txtSupplierFilter.Size = new Size(475, 22);
            txtSupplierFilter.TabIndex = 21;
            // 
            // txtNameFilter
            // 
            txtNameFilter.Location = new Point(201, 23);
            txtNameFilter.Name = "txtNameFilter";
            txtNameFilter.Size = new Size(475, 22);
            txtNameFilter.TabIndex = 20;
            // 
            // chbTypeProduct
            // 
            chbTypeProduct.AutoSize = true;
            chbTypeProduct.Checked = true;
            chbTypeProduct.CheckState = CheckState.Checked;
            chbTypeProduct.Location = new Point(15, 119);
            chbTypeProduct.Name = "chbTypeProduct";
            chbTypeProduct.Size = new Size(114, 20);
            chbTypeProduct.TabIndex = 19;
            chbTypeProduct.Text = "Loại sản phẩm";
            chbTypeProduct.UseVisualStyleBackColor = true;
            // 
            // chbSupplier
            // 
            chbSupplier.AutoSize = true;
            chbSupplier.Checked = true;
            chbSupplier.CheckState = CheckState.Checked;
            chbSupplier.Location = new Point(15, 88);
            chbSupplier.Name = "chbSupplier";
            chbSupplier.Size = new Size(103, 20);
            chbSupplier.TabIndex = 18;
            chbSupplier.Text = "Nhà sản xuất";
            chbSupplier.UseVisualStyleBackColor = true;
            // 
            // chbPrice
            // 
            chbPrice.AutoSize = true;
            chbPrice.Checked = true;
            chbPrice.CheckState = CheckState.Checked;
            chbPrice.Location = new Point(15, 56);
            chbPrice.Name = "chbPrice";
            chbPrice.Size = new Size(90, 20);
            chbPrice.TabIndex = 17;
            chbPrice.Text = "Giá (nghìn)";
            chbPrice.UseVisualStyleBackColor = true;
            // 
            // chbName
            // 
            chbName.AutoSize = true;
            chbName.Checked = true;
            chbName.CheckState = CheckState.Checked;
            chbName.Location = new Point(15, 25);
            chbName.Name = "chbName";
            chbName.Size = new Size(112, 20);
            chbName.TabIndex = 16;
            chbName.Text = "Tên sản phẩm";
            chbName.UseVisualStyleBackColor = true;
            // 
            // UCImported
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "UCImported";
            Size = new Size(1350, 768);
            pnlMain.ResumeLayout(false);
            gbMakeBill.ResumeLayout(false);
            gbMakeBill.PerformLayout();
            gbListProduct.ResumeLayout(false);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDFrom).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbMakeBill;
        private System.Windows.Forms.Button btnMakeBills;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.GroupBox gbListProduct;
        private System.Windows.Forms.DateTimePicker dtPickDateCreate;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnMakeNewProduct;
        private System.Windows.Forms.Button btnCheckSupplier;
        private System.Windows.Forms.Button btnChooseProduct;
        private System.Windows.Forms.Button btnCheckHistory;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
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
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel flowpnl_Item;
    }
}
