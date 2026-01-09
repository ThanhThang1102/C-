namespace buithanhthang_2121110129.UserControl
{
    partial class UCHomePage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlMain = new Panel();
            gbYourInfor = new GroupBox();
            lblYourGender = new Label();
            lblYourName = new Label();
            lblYourPhone = new Label();
            picStaff = new PictureBox();
            lblYourEmail = new Label();
            pnlCustomer = new GroupBox();
            btnReloadCustomer = new Button();
            dgvCustomer = new DataGridView();
            btnChangeCustomerInfor = new Button();
            btnAddCustomer = new Button();
            gbCustomerLevel = new GroupBox();
            picCustomerLevel = new PictureBox();
            dtCustomerDateJoin = new DateTimePicker();
            txtCustomerName = new TextBox();
            txtCustomerValue = new TextBox();
            txtCustomerPhone = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            gbStoreContact = new GroupBox();
            btnChangeStoreInfor = new Button();
            picStoreLocation = new PictureBox();
            pictContact = new PictureBox();
            picYoutube = new PictureBox();
            picLinkedIn = new PictureBox();
            picInsta = new PictureBox();
            picFace = new PictureBox();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            gbStoreInfor = new GroupBox();
            gbStatisticProduct = new GroupBox();
            chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            gbProductNewImport = new GroupBox();
            listBoxProductNewImport = new ListBox();
            pnlValue = new Panel();
            txtProfit = new TextBox();
            label5 = new Label();
            txtTotalSpending = new TextBox();
            label4 = new Label();
            txtTotalIncome = new TextBox();
            label3 = new Label();
            txtSpendingDay = new TextBox();
            label2 = new Label();
            txtIncomeDay = new TextBox();
            btnReloadValue = new Button();
            label1 = new Label();
            pnlMain.SuspendLayout();
            gbYourInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStaff).BeginInit();
            pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            gbCustomerLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCustomerLevel).BeginInit();
            gbStoreContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStoreLocation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picYoutube).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLinkedIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInsta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFace).BeginInit();
            gbStoreInfor.SuspendLayout();
            gbStatisticProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProduct).BeginInit();
            gbProductNewImport.SuspendLayout();
            pnlValue.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.DeepSkyBlue;
            pnlMain.Controls.Add(gbYourInfor);
            pnlMain.Controls.Add(pnlCustomer);
            pnlMain.Controls.Add(gbStoreContact);
            pnlMain.Controls.Add(gbStoreInfor);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1366, 733);
            pnlMain.TabIndex = 0;
            // 
            // gbYourInfor
            // 
            gbYourInfor.BackColor = Color.CornflowerBlue;
            gbYourInfor.Controls.Add(lblYourGender);
            gbYourInfor.Controls.Add(lblYourName);
            gbYourInfor.Controls.Add(lblYourPhone);
            gbYourInfor.Controls.Add(picStaff);
            gbYourInfor.Controls.Add(lblYourEmail);
            gbYourInfor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbYourInfor.ForeColor = Color.White;
            gbYourInfor.Location = new Point(679, 456);
            gbYourInfor.Name = "gbYourInfor";
            gbYourInfor.Size = new Size(684, 274);
            gbYourInfor.TabIndex = 2;
            gbYourInfor.TabStop = false;
            gbYourInfor.Text = "Thông tin cá nhân";
            // 
            // lblYourGender
            // 
            lblYourGender.AutoSize = true;
            lblYourGender.ForeColor = Color.White;
            lblYourGender.Location = new Point(190, 82);
            lblYourGender.Name = "lblYourGender";
            lblYourGender.Size = new Size(71, 16);
            lblYourGender.TabIndex = 23;
            lblYourGender.Text = "Giới tính: ";
            // 
            // lblYourName
            // 
            lblYourName.AutoSize = true;
            lblYourName.ForeColor = Color.White;
            lblYourName.Location = new Point(190, 39);
            lblYourName.Name = "lblYourName";
            lblYourName.Size = new Size(60, 16);
            lblYourName.TabIndex = 22;
            lblYourName.Text = "Họ tên: ";
            // 
            // lblYourPhone
            // 
            lblYourPhone.AutoSize = true;
            lblYourPhone.ForeColor = Color.White;
            lblYourPhone.Location = new Point(190, 168);
            lblYourPhone.Name = "lblYourPhone";
            lblYourPhone.Size = new Size(106, 16);
            lblYourPhone.TabIndex = 21;
            lblYourPhone.Text = "Số điện thoại: ";
            // 
            // picStaff
            // 
            picStaff.BackColor = Color.FromArgb(224, 224, 224);
            picStaff.Location = new Point(18, 39);
            picStaff.Name = "picStaff";
            picStaff.Size = new Size(150, 200);
            picStaff.SizeMode = PictureBoxSizeMode.StretchImage;
            picStaff.TabIndex = 0;
            picStaff.TabStop = false;
            // 
            // lblYourEmail
            // 
            lblYourEmail.AutoSize = true;
            lblYourEmail.ForeColor = Color.White;
            lblYourEmail.Location = new Point(190, 125);
            lblYourEmail.Name = "lblYourEmail";
            lblYourEmail.Size = new Size(54, 16);
            lblYourEmail.TabIndex = 20;
            lblYourEmail.Text = "Email: ";
            // 
            // pnlCustomer
            // 
            pnlCustomer.BackColor = Color.LightSkyBlue;
            pnlCustomer.Controls.Add(btnReloadCustomer);
            pnlCustomer.Controls.Add(dgvCustomer);
            pnlCustomer.Controls.Add(btnChangeCustomerInfor);
            pnlCustomer.Controls.Add(btnAddCustomer);
            pnlCustomer.Controls.Add(gbCustomerLevel);
            pnlCustomer.Controls.Add(dtCustomerDateJoin);
            pnlCustomer.Controls.Add(txtCustomerName);
            pnlCustomer.Controls.Add(txtCustomerValue);
            pnlCustomer.Controls.Add(txtCustomerPhone);
            pnlCustomer.Controls.Add(label8);
            pnlCustomer.Controls.Add(label9);
            pnlCustomer.Controls.Add(label6);
            pnlCustomer.Controls.Add(label7);
            pnlCustomer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlCustomer.Location = new Point(679, 3);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(684, 452);
            pnlCustomer.TabIndex = 2;
            pnlCustomer.TabStop = false;
            pnlCustomer.Text = "Thông tin khách hàng";
            // 
            // btnReloadCustomer
            // 
            btnReloadCustomer.ForeColor = Color.Black;
            btnReloadCustomer.Location = new Point(6, 140);
            btnReloadCustomer.Name = "btnReloadCustomer";
            btnReloadCustomer.Size = new Size(146, 28);
            btnReloadCustomer.TabIndex = 34;
            btnReloadCustomer.Text = "Tải lại thông tin";
            btnReloadCustomer.UseVisualStyleBackColor = true;
            btnReloadCustomer.Click += btnReloadCustomer_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Location = new Point(6, 174);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomer.Size = new Size(672, 273);
            dgvCustomer.TabIndex = 33;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // btnChangeCustomerInfor
            // 
            btnChangeCustomerInfor.ForeColor = Color.Black;
            btnChangeCustomerInfor.Location = new Point(303, 140);
            btnChangeCustomerInfor.Name = "btnChangeCustomerInfor";
            btnChangeCustomerInfor.Size = new Size(202, 28);
            btnChangeCustomerInfor.TabIndex = 32;
            btnChangeCustomerInfor.Text = "Đổi thông tin khách hàng";
            btnChangeCustomerInfor.UseVisualStyleBackColor = true;
            btnChangeCustomerInfor.Click += btnChangeCustomerInfor_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.ForeColor = Color.Black;
            btnAddCustomer.Location = new Point(158, 140);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(139, 28);
            btnAddCustomer.TabIndex = 24;
            btnAddCustomer.Text = "Thêm khách hàng";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // gbCustomerLevel
            // 
            gbCustomerLevel.Controls.Add(picCustomerLevel);
            gbCustomerLevel.Location = new Point(512, 18);
            gbCustomerLevel.Name = "gbCustomerLevel";
            gbCustomerLevel.Size = new Size(150, 150);
            gbCustomerLevel.TabIndex = 31;
            gbCustomerLevel.TabStop = false;
            gbCustomerLevel.Text = "Cấp độ";
            // 
            // picCustomerLevel
            // 
            picCustomerLevel.BackColor = Color.Thistle;
            picCustomerLevel.BackgroundImageLayout = ImageLayout.Stretch;
            picCustomerLevel.Location = new Point(22, 26);
            picCustomerLevel.Name = "picCustomerLevel";
            picCustomerLevel.Size = new Size(110, 110);
            picCustomerLevel.TabIndex = 0;
            picCustomerLevel.TabStop = false;
            // 
            // dtCustomerDateJoin
            // 
            dtCustomerDateJoin.Enabled = false;
            dtCustomerDateJoin.Format = DateTimePickerFormat.Short;
            dtCustomerDateJoin.Location = new Point(192, 80);
            dtCustomerDateJoin.Name = "dtCustomerDateJoin";
            dtCustomerDateJoin.Size = new Size(313, 22);
            dtCustomerDateJoin.TabIndex = 30;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(192, 20);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(313, 22);
            txtCustomerName.TabIndex = 29;
            // 
            // txtCustomerValue
            // 
            txtCustomerValue.Location = new Point(192, 112);
            txtCustomerValue.Name = "txtCustomerValue";
            txtCustomerValue.ReadOnly = true;
            txtCustomerValue.Size = new Size(313, 22);
            txtCustomerValue.TabIndex = 28;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(192, 49);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.ReadOnly = true;
            txtCustomerPhone.Size = new Size(313, 22);
            txtCustomerPhone.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(15, 83);
            label8.Name = "label8";
            label8.Size = new Size(111, 16);
            label8.TabIndex = 27;
            label8.Text = "Ngày tham gia:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 115);
            label9.Name = "label9";
            label9.Size = new Size(108, 16);
            label9.TabIndex = 26;
            label9.Text = "Giá trị tích lũy: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(14, 23);
            label6.Name = "label6";
            label6.Size = new Size(60, 16);
            label6.TabIndex = 25;
            label6.Text = "Họ tên: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 52);
            label7.Name = "label7";
            label7.Size = new Size(106, 16);
            label7.TabIndex = 24;
            label7.Text = "Số điện thoại: ";
            // 
            // gbStoreContact
            // 
            gbStoreContact.BackColor = Color.CornflowerBlue;
            gbStoreContact.Controls.Add(btnChangeStoreInfor);
            gbStoreContact.Controls.Add(picStoreLocation);
            gbStoreContact.Controls.Add(pictContact);
            gbStoreContact.Controls.Add(picYoutube);
            gbStoreContact.Controls.Add(picLinkedIn);
            gbStoreContact.Controls.Add(picInsta);
            gbStoreContact.Controls.Add(picFace);
            gbStoreContact.Controls.Add(lblPhone);
            gbStoreContact.Controls.Add(lblEmail);
            gbStoreContact.Controls.Add(lblAddress);
            gbStoreContact.ForeColor = Color.White;
            gbStoreContact.Location = new Point(3, 456);
            gbStoreContact.Name = "gbStoreContact";
            gbStoreContact.Size = new Size(670, 274);
            gbStoreContact.TabIndex = 1;
            gbStoreContact.TabStop = false;
            gbStoreContact.Text = "Cửa hàng";
            // 
            // btnChangeStoreInfor
            // 
            btnChangeStoreInfor.ForeColor = Color.Black;
            btnChangeStoreInfor.Location = new Point(412, 201);
            btnChangeStoreInfor.Name = "btnChangeStoreInfor";
            btnChangeStoreInfor.Size = new Size(252, 60);
            btnChangeStoreInfor.TabIndex = 11;
            btnChangeStoreInfor.Text = "Đổi thông tin";
            btnChangeStoreInfor.UseVisualStyleBackColor = true;
            btnChangeStoreInfor.Click += btnChangeStoreInfor_Click;
            // 
            // picStoreLocation
            // 
            picStoreLocation.Cursor = Cursors.Hand;
            picStoreLocation.Image = Properties.Resources.icons8_location_32;
            picStoreLocation.Location = new Point(6, 201);
            picStoreLocation.Name = "picStoreLocation";
            picStoreLocation.Size = new Size(60, 60);
            picStoreLocation.SizeMode = PictureBoxSizeMode.CenterImage;
            picStoreLocation.TabIndex = 19;
            picStoreLocation.TabStop = false;
            picStoreLocation.Click += picStoreLocation_Click;
            // 
            // pictContact
            // 
            pictContact.Cursor = Cursors.Hand;
            pictContact.Image = Properties.Resources.icons8_call_32;
            pictContact.Location = new Point(336, 201);
            pictContact.Name = "pictContact";
            pictContact.Size = new Size(60, 60);
            pictContact.SizeMode = PictureBoxSizeMode.CenterImage;
            pictContact.TabIndex = 18;
            pictContact.TabStop = false;
            pictContact.Click += pictContact_Click;
            // 
            // picYoutube
            // 
            picYoutube.Cursor = Cursors.Hand;
            picYoutube.Image = Properties.Resources.icons8_YouTube_32;
            picYoutube.Location = new Point(270, 201);
            picYoutube.Name = "picYoutube";
            picYoutube.Size = new Size(60, 60);
            picYoutube.SizeMode = PictureBoxSizeMode.CenterImage;
            picYoutube.TabIndex = 17;
            picYoutube.TabStop = false;
            picYoutube.Click += picYoutube_Click;
            // 
            // picLinkedIn
            // 
            picLinkedIn.Cursor = Cursors.Hand;
            picLinkedIn.Image = Properties.Resources.icons8_linkedin_32;
            picLinkedIn.Location = new Point(204, 201);
            picLinkedIn.Name = "picLinkedIn";
            picLinkedIn.Size = new Size(60, 60);
            picLinkedIn.SizeMode = PictureBoxSizeMode.CenterImage;
            picLinkedIn.TabIndex = 16;
            picLinkedIn.TabStop = false;
            picLinkedIn.Click += picLinkedIn_Click;
            // 
            // picInsta
            // 
            picInsta.Cursor = Cursors.Hand;
            picInsta.Image = Properties.Resources.icons8_Instagram_32;
            picInsta.Location = new Point(138, 201);
            picInsta.Name = "picInsta";
            picInsta.Size = new Size(60, 60);
            picInsta.SizeMode = PictureBoxSizeMode.CenterImage;
            picInsta.TabIndex = 15;
            picInsta.TabStop = false;
            picInsta.Click += picInsta_Click;
            // 
            // picFace
            // 
            picFace.Cursor = Cursors.Hand;
            picFace.Image = Properties.Resources.icons8_facebook_48;
            picFace.Location = new Point(72, 201);
            picFace.Name = "picFace";
            picFace.Size = new Size(60, 60);
            picFace.SizeMode = PictureBoxSizeMode.CenterImage;
            picFace.TabIndex = 14;
            picFace.TabStop = false;
            picFace.Click += picFace_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.White;
            lblPhone.Location = new Point(21, 168);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(146, 24);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Số điện thoại: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(21, 125);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 24);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email: ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(21, 39);
            lblAddress.MaximumSize = new Size(450, 24);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(86, 24);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Địa chỉ: ";
            // 
            // gbStoreInfor
            // 
            gbStoreInfor.BackColor = Color.LightSkyBlue;
            gbStoreInfor.Controls.Add(gbStatisticProduct);
            gbStoreInfor.Controls.Add(gbProductNewImport);
            gbStoreInfor.Controls.Add(pnlValue);
            gbStoreInfor.Location = new Point(3, 3);
            gbStoreInfor.Name = "gbStoreInfor";
            gbStoreInfor.Size = new Size(670, 452);
            gbStoreInfor.TabIndex = 0;
            gbStoreInfor.TabStop = false;
            gbStoreInfor.Text = "Thông tin chung";
            // 
            // gbStatisticProduct
            // 
            gbStatisticProduct.Controls.Add(chartProduct);
            gbStatisticProduct.Location = new Point(346, 149);
            gbStatisticProduct.Name = "gbStatisticProduct";
            gbStatisticProduct.Size = new Size(318, 298);
            gbStatisticProduct.TabIndex = 2;
            gbStatisticProduct.TabStop = false;
            gbStatisticProduct.Text = "Biểu đồ sản phẩm bán ra";
            // 
            // chartProduct
            // 
            chartArea1.Name = "ChartArea1";
            chartProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartProduct.Legends.Add(legend1);
            chartProduct.Location = new Point(6, 30);
            chartProduct.Name = "chartProduct";
            chartProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartProduct.Series.Add(series1);
            chartProduct.Size = new Size(306, 262);
            chartProduct.TabIndex = 0;
            chartProduct.Text = "Product";
            // 
            // gbProductNewImport
            // 
            gbProductNewImport.AccessibleRole = AccessibleRole.None;
            gbProductNewImport.Controls.Add(listBoxProductNewImport);
            gbProductNewImport.Location = new Point(346, 18);
            gbProductNewImport.Name = "gbProductNewImport";
            gbProductNewImport.Size = new Size(318, 130);
            gbProductNewImport.TabIndex = 1;
            gbProductNewImport.TabStop = false;
            gbProductNewImport.Text = "Sản phẩm mới nhập hàng";
            // 
            // listBoxProductNewImport
            // 
            listBoxProductNewImport.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxProductNewImport.FormattingEnabled = true;
            listBoxProductNewImport.Location = new Point(6, 30);
            listBoxProductNewImport.Name = "listBoxProductNewImport";
            listBoxProductNewImport.Size = new Size(306, 95);
            listBoxProductNewImport.TabIndex = 0;
            // 
            // pnlValue
            // 
            pnlValue.BackColor = Color.DarkCyan;
            pnlValue.Controls.Add(txtProfit);
            pnlValue.Controls.Add(label5);
            pnlValue.Controls.Add(txtTotalSpending);
            pnlValue.Controls.Add(label4);
            pnlValue.Controls.Add(txtTotalIncome);
            pnlValue.Controls.Add(label3);
            pnlValue.Controls.Add(txtSpendingDay);
            pnlValue.Controls.Add(label2);
            pnlValue.Controls.Add(txtIncomeDay);
            pnlValue.Controls.Add(btnReloadValue);
            pnlValue.Controls.Add(label1);
            pnlValue.Location = new Point(6, 30);
            pnlValue.Name = "pnlValue";
            pnlValue.Size = new Size(334, 417);
            pnlValue.TabIndex = 0;
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(20, 339);
            txtProfit.Name = "txtProfit";
            txtProfit.ReadOnly = true;
            txtProfit.Size = new Size(290, 29);
            txtProfit.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 311);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 9;
            label5.Text = "Lợi nhuận";
            // 
            // txtTotalSpending
            // 
            txtTotalSpending.Location = new Point(20, 259);
            txtTotalSpending.Name = "txtTotalSpending";
            txtTotalSpending.ReadOnly = true;
            txtTotalSpending.Size = new Size(290, 29);
            txtTotalSpending.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 231);
            label4.Name = "label4";
            label4.Size = new Size(133, 24);
            label4.TabIndex = 7;
            label4.Text = "Tổng chi tiêu";
            // 
            // txtTotalIncome
            // 
            txtTotalIncome.Location = new Point(20, 177);
            txtTotalIncome.Name = "txtTotalIncome";
            txtTotalIncome.ReadOnly = true;
            txtTotalIncome.Size = new Size(290, 29);
            txtTotalIncome.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 149);
            label3.Name = "label3";
            label3.Size = new Size(147, 24);
            label3.TabIndex = 5;
            label3.Text = "Tổng thu nhập";
            // 
            // txtSpendingDay
            // 
            txtSpendingDay.Location = new Point(20, 100);
            txtSpendingDay.Name = "txtSpendingDay";
            txtSpendingDay.ReadOnly = true;
            txtSpendingDay.Size = new Size(290, 29);
            txtSpendingDay.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 72);
            label2.Name = "label2";
            label2.Size = new Size(186, 24);
            label2.TabIndex = 3;
            label2.Text = "Chi tiêu trong ngày";
            // 
            // txtIncomeDay
            // 
            txtIncomeDay.Location = new Point(20, 33);
            txtIncomeDay.Name = "txtIncomeDay";
            txtIncomeDay.ReadOnly = true;
            txtIncomeDay.Size = new Size(290, 29);
            txtIncomeDay.TabIndex = 2;
            // 
            // btnReloadValue
            // 
            btnReloadValue.Location = new Point(66, 372);
            btnReloadValue.Name = "btnReloadValue";
            btnReloadValue.Size = new Size(214, 39);
            btnReloadValue.TabIndex = 1;
            btnReloadValue.Text = "Lọc lại";
            btnReloadValue.UseVisualStyleBackColor = true;
            btnReloadValue.Click += btnReloadValue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(205, 24);
            label1.TabIndex = 0;
            label1.Text = "Thu nhập trong ngày";
            // 
            // UCHomePage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "UCHomePage";
            Size = new Size(1366, 733);
            pnlMain.ResumeLayout(false);
            gbYourInfor.ResumeLayout(false);
            gbYourInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStaff).EndInit();
            pnlCustomer.ResumeLayout(false);
            pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            gbCustomerLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCustomerLevel).EndInit();
            gbStoreContact.ResumeLayout(false);
            gbStoreContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStoreLocation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)picYoutube).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLinkedIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInsta).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFace).EndInit();
            gbStoreInfor.ResumeLayout(false);
            gbStatisticProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartProduct).EndInit();
            gbProductNewImport.ResumeLayout(false);
            pnlValue.ResumeLayout(false);
            pnlValue.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbStoreInfor;
        private System.Windows.Forms.GroupBox gbYourInfor;
        private System.Windows.Forms.GroupBox pnlCustomer;
        private System.Windows.Forms.GroupBox gbStoreContact;
        private System.Windows.Forms.Button btnChangeStoreInfor;
        private System.Windows.Forms.PictureBox picStoreLocation;
        private System.Windows.Forms.PictureBox pictContact;
        private System.Windows.Forms.PictureBox picYoutube;
        private System.Windows.Forms.PictureBox picLinkedIn;
        private System.Windows.Forms.PictureBox picInsta;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox gbStatisticProduct;
        private System.Windows.Forms.GroupBox gbProductNewImport;
        private System.Windows.Forms.ListBox listBoxProductNewImport;
        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalSpending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncomeDay;
        private System.Windows.Forms.Button btnReloadValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.Label lblYourGender;
        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.Label lblYourPhone;
        private System.Windows.Forms.PictureBox picStaff;
        private System.Windows.Forms.Label lblYourEmail;
        private System.Windows.Forms.DateTimePicker dtCustomerDateJoin;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerValue;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbCustomerLevel;
        private System.Windows.Forms.PictureBox picCustomerLevel;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnChangeCustomerInfor;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnReloadCustomer;
    }
}
