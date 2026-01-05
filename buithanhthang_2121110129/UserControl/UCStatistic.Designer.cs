namespace buithanhthang_2121110129.UserControl
{
    partial class UCStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlMain = new Panel();
            gbMakeReport = new GroupBox();
            gbChooseReportInfor = new GroupBox();
            chbReportStaff = new CheckBox();
            chbReportSupplier = new CheckBox();
            chbReportProduct = new CheckBox();
            chbReportImport = new CheckBox();
            chbReportOrder = new CheckBox();
            chbReportAll = new CheckBox();
            chbReportSpending = new CheckBox();
            chbReportIncome = new CheckBox();
            gbTimeReport = new GroupBox();
            radReportAll = new RadioButton();
            radReport1year = new RadioButton();
            radReport3months = new RadioButton();
            radReport30days = new RadioButton();
            radReport7days = new RadioButton();
            radReportToday = new RadioButton();
            btnOutputReport = new Button();
            groupBox2 = new GroupBox();
            gbCheckTypeProductChart = new GroupBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            cbTypeChartProduct = new ComboBox();
            gbCheckTimeProduct = new GroupBox();
            btnMakeChartProduct = new Button();
            rad12monthsProduct = new RadioButton();
            rad30daysProduct = new RadioButton();
            rad7daysProduct = new RadioButton();
            cbInformationPlus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            gbSales = new GroupBox();
            gbCheckTime = new GroupBox();
            btnCreateChart = new Button();
            rad6months = new RadioButton();
            rad5years = new RadioButton();
            rad7days = new RadioButton();
            chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            gbImportHistory = new GroupBox();
            btnReloadImportHistory = new Button();
            dgvImportHistory = new DataGridView();
            gbSellingHistory = new GroupBox();
            btnReloadSellingHistory = new Button();
            dgvSellingHistory = new DataGridView();
            pnlMain.SuspendLayout();
            gbMakeReport.SuspendLayout();
            gbChooseReportInfor.SuspendLayout();
            gbTimeReport.SuspendLayout();
            groupBox2.SuspendLayout();
            gbCheckTypeProductChart.SuspendLayout();
            gbCheckTimeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbInformationPlus).BeginInit();
            gbSales.SuspendLayout();
            gbCheckTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSales).BeginInit();
            gbImportHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImportHistory).BeginInit();
            gbSellingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSellingHistory).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.MediumAquamarine;
            pnlMain.Controls.Add(gbMakeReport);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Controls.Add(gbSales);
            pnlMain.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1350, 768);
            pnlMain.TabIndex = 2;
            // 
            // gbMakeReport
            // 
            gbMakeReport.BackColor = Color.Aquamarine;
            gbMakeReport.Controls.Add(gbChooseReportInfor);
            gbMakeReport.Controls.Add(gbTimeReport);
            gbMakeReport.Controls.Add(btnOutputReport);
            gbMakeReport.Location = new Point(809, 444);
            gbMakeReport.Name = "gbMakeReport";
            gbMakeReport.Size = new Size(538, 264);
            gbMakeReport.TabIndex = 2;
            gbMakeReport.TabStop = false;
            gbMakeReport.Text = "Tạo báo cáo";
            // 
            // gbChooseReportInfor
            // 
            gbChooseReportInfor.BackColor = Color.Turquoise;
            gbChooseReportInfor.Controls.Add(chbReportStaff);
            gbChooseReportInfor.Controls.Add(chbReportSupplier);
            gbChooseReportInfor.Controls.Add(chbReportProduct);
            gbChooseReportInfor.Controls.Add(chbReportImport);
            gbChooseReportInfor.Controls.Add(chbReportOrder);
            gbChooseReportInfor.Controls.Add(chbReportAll);
            gbChooseReportInfor.Controls.Add(chbReportSpending);
            gbChooseReportInfor.Controls.Add(chbReportIncome);
            gbChooseReportInfor.ForeColor = Color.Black;
            gbChooseReportInfor.Location = new Point(229, 23);
            gbChooseReportInfor.Name = "gbChooseReportInfor";
            gbChooseReportInfor.Size = new Size(297, 194);
            gbChooseReportInfor.TabIndex = 7;
            gbChooseReportInfor.TabStop = false;
            gbChooseReportInfor.Text = "Chọn thông tin";
            // 
            // chbReportStaff
            // 
            chbReportStaff.AutoSize = true;
            chbReportStaff.Location = new Point(6, 132);
            chbReportStaff.Name = "chbReportStaff";
            chbReportStaff.Size = new Size(115, 28);
            chbReportStaff.TabIndex = 8;
            chbReportStaff.Text = "Nhân viên";
            chbReportStaff.UseVisualStyleBackColor = true;
            // 
            // chbReportSupplier
            // 
            chbReportSupplier.AutoSize = true;
            chbReportSupplier.Location = new Point(6, 103);
            chbReportSupplier.Name = "chbReportSupplier";
            chbReportSupplier.Size = new Size(148, 28);
            chbReportSupplier.TabIndex = 7;
            chbReportSupplier.Text = "Nhà cung cấp";
            chbReportSupplier.UseVisualStyleBackColor = true;
            // 
            // chbReportProduct
            // 
            chbReportProduct.AutoSize = true;
            chbReportProduct.Location = new Point(6, 77);
            chbReportProduct.Name = "chbReportProduct";
            chbReportProduct.Size = new Size(115, 28);
            chbReportProduct.TabIndex = 6;
            chbReportProduct.Text = "Sản phẩm";
            chbReportProduct.UseVisualStyleBackColor = true;
            // 
            // chbReportImport
            // 
            chbReportImport.AutoSize = true;
            chbReportImport.Location = new Point(6, 50);
            chbReportImport.Name = "chbReportImport";
            chbReportImport.Size = new Size(126, 28);
            chbReportImport.TabIndex = 5;
            chbReportImport.Text = "Phiếu nhập";
            chbReportImport.UseVisualStyleBackColor = true;
            // 
            // chbReportOrder
            // 
            chbReportOrder.AutoSize = true;
            chbReportOrder.Location = new Point(6, 24);
            chbReportOrder.Name = "chbReportOrder";
            chbReportOrder.Size = new Size(103, 28);
            chbReportOrder.TabIndex = 4;
            chbReportOrder.Text = "Hóa đơn";
            chbReportOrder.UseVisualStyleBackColor = true;
            // 
            // chbReportAll
            // 
            chbReportAll.AutoSize = true;
            chbReportAll.Location = new Point(6, 161);
            chbReportAll.Name = "chbReportAll";
            chbReportAll.Size = new Size(80, 28);
            chbReportAll.TabIndex = 3;
            chbReportAll.Text = "Tất cả";
            chbReportAll.UseVisualStyleBackColor = true;
            // 
            // chbReportSpending
            // 
            chbReportSpending.AutoSize = true;
            chbReportSpending.Enabled = false;
            chbReportSpending.Location = new Point(168, 48);
            chbReportSpending.Name = "chbReportSpending";
            chbReportSpending.Size = new Size(92, 28);
            chbReportSpending.TabIndex = 1;
            chbReportSpending.Text = "Chi tiêu";
            chbReportSpending.UseVisualStyleBackColor = true;
            // 
            // chbReportIncome
            // 
            chbReportIncome.AutoSize = true;
            chbReportIncome.Enabled = false;
            chbReportIncome.Location = new Point(168, 21);
            chbReportIncome.Name = "chbReportIncome";
            chbReportIncome.Size = new Size(111, 28);
            chbReportIncome.TabIndex = 0;
            chbReportIncome.Text = "Thu nhập";
            chbReportIncome.UseVisualStyleBackColor = true;
            // 
            // gbTimeReport
            // 
            gbTimeReport.BackColor = Color.Turquoise;
            gbTimeReport.Controls.Add(radReportAll);
            gbTimeReport.Controls.Add(radReport1year);
            gbTimeReport.Controls.Add(radReport3months);
            gbTimeReport.Controls.Add(radReport30days);
            gbTimeReport.Controls.Add(radReport7days);
            gbTimeReport.Controls.Add(radReportToday);
            gbTimeReport.ForeColor = Color.Black;
            gbTimeReport.Location = new Point(12, 23);
            gbTimeReport.Name = "gbTimeReport";
            gbTimeReport.Size = new Size(211, 232);
            gbTimeReport.TabIndex = 8;
            gbTimeReport.TabStop = false;
            gbTimeReport.Text = "Chọn Thời gian";
            // 
            // radReportAll
            // 
            radReportAll.AutoSize = true;
            radReportAll.Location = new Point(6, 178);
            radReportAll.Name = "radReportAll";
            radReportAll.Size = new Size(99, 28);
            radReportAll.TabIndex = 5;
            radReportAll.Text = "Toàn bộ";
            radReportAll.UseVisualStyleBackColor = true;
            // 
            // radReport1year
            // 
            radReport1year.AutoSize = true;
            radReport1year.Location = new Point(6, 142);
            radReport1year.Name = "radReport1year";
            radReport1year.Size = new Size(80, 28);
            radReport1year.TabIndex = 4;
            radReport1year.Text = "1 năm";
            radReport1year.UseVisualStyleBackColor = true;
            // 
            // radReport3months
            // 
            radReport3months.AutoSize = true;
            radReport3months.Location = new Point(6, 110);
            radReport3months.Name = "radReport3months";
            radReport3months.Size = new Size(168, 28);
            radReport3months.TabIndex = 3;
            radReport3months.Text = "3 tháng gần nhất";
            radReport3months.UseVisualStyleBackColor = true;
            // 
            // radReport30days
            // 
            radReport30days.AutoSize = true;
            radReport30days.Location = new Point(6, 78);
            radReport30days.Name = "radReport30days";
            radReport30days.Size = new Size(94, 28);
            radReport30days.TabIndex = 2;
            radReport30days.Text = "30 ngày";
            radReport30days.UseVisualStyleBackColor = true;
            // 
            // radReport7days
            // 
            radReport7days.AutoSize = true;
            radReport7days.Location = new Point(6, 49);
            radReport7days.Name = "radReport7days";
            radReport7days.Size = new Size(84, 28);
            radReport7days.TabIndex = 1;
            radReport7days.Text = "7 ngày";
            radReport7days.UseVisualStyleBackColor = true;
            // 
            // radReportToday
            // 
            radReportToday.AutoSize = true;
            radReportToday.Checked = true;
            radReportToday.Location = new Point(6, 21);
            radReportToday.Name = "radReportToday";
            radReportToday.Size = new Size(104, 28);
            radReportToday.TabIndex = 0;
            radReportToday.TabStop = true;
            radReportToday.Text = "Hôm nay";
            radReportToday.UseVisualStyleBackColor = true;
            radReportToday.CheckedChanged += radReportToday_CheckedChanged;
            // 
            // btnOutputReport
            // 
            btnOutputReport.Location = new Point(229, 219);
            btnOutputReport.Name = "btnOutputReport";
            btnOutputReport.Size = new Size(303, 36);
            btnOutputReport.TabIndex = 4;
            btnOutputReport.Text = "Xuất báo cáo";
            btnOutputReport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Aquamarine;
            groupBox2.Controls.Add(gbCheckTypeProductChart);
            groupBox2.Controls.Add(gbCheckTimeProduct);
            groupBox2.Controls.Add(cbInformationPlus);
            groupBox2.Location = new Point(809, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(538, 435);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm trong cửa hàng";
            // 
            // gbCheckTypeProductChart
            // 
            gbCheckTypeProductChart.BackColor = Color.Turquoise;
            gbCheckTypeProductChart.Controls.Add(comboBox1);
            gbCheckTypeProductChart.Controls.Add(label1);
            gbCheckTypeProductChart.Controls.Add(cbTypeChartProduct);
            gbCheckTypeProductChart.ForeColor = Color.Black;
            gbCheckTypeProductChart.Location = new Point(6, 26);
            gbCheckTypeProductChart.Name = "gbCheckTypeProductChart";
            gbCheckTypeProductChart.Size = new Size(526, 129);
            gbCheckTypeProductChart.TabIndex = 9;
            gbCheckTypeProductChart.TabStop = false;
            gbCheckTypeProductChart.Text = "Chọn dạng biểu đồ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(514, 32);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 64);
            label1.Name = "label1";
            label1.Size = new Size(214, 24);
            label1.TabIndex = 2;
            label1.Text = "Chi tiết tìm kiếm bổ sung";
            // 
            // cbTypeChartProduct
            // 
            cbTypeChartProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeChartProduct.FormattingEnabled = true;
            cbTypeChartProduct.Items.AddRange(new object[] { "Phần trăm sản phẩm nhập vào theo tên", "Phần trăm sản phẩm nhập vào theo loại", "Phần trăm sản phẩm bán ra theo tên", "Phần trăm sản phẩm bán ra theo loại", "Doanh số sản phẩm bán ra tùy chọn" });
            cbTypeChartProduct.Location = new Point(6, 28);
            cbTypeChartProduct.Name = "cbTypeChartProduct";
            cbTypeChartProduct.Size = new Size(514, 32);
            cbTypeChartProduct.TabIndex = 0;
            // 
            // gbCheckTimeProduct
            // 
            gbCheckTimeProduct.BackColor = Color.Turquoise;
            gbCheckTimeProduct.Controls.Add(btnMakeChartProduct);
            gbCheckTimeProduct.Controls.Add(rad12monthsProduct);
            gbCheckTimeProduct.Controls.Add(rad30daysProduct);
            gbCheckTimeProduct.Controls.Add(rad7daysProduct);
            gbCheckTimeProduct.ForeColor = Color.Black;
            gbCheckTimeProduct.Location = new Point(6, 161);
            gbCheckTimeProduct.Name = "gbCheckTimeProduct";
            gbCheckTimeProduct.Size = new Size(526, 62);
            gbCheckTimeProduct.TabIndex = 8;
            gbCheckTimeProduct.TabStop = false;
            gbCheckTimeProduct.Text = "Chọn Thời gian";
            // 
            // btnMakeChartProduct
            // 
            btnMakeChartProduct.Location = new Point(355, 21);
            btnMakeChartProduct.Name = "btnMakeChartProduct";
            btnMakeChartProduct.Size = new Size(165, 36);
            btnMakeChartProduct.TabIndex = 3;
            btnMakeChartProduct.Text = "Tạo biểu đồ";
            btnMakeChartProduct.UseVisualStyleBackColor = true;
            // 
            // rad12monthsProduct
            // 
            rad12monthsProduct.AutoSize = true;
            rad12monthsProduct.Location = new Point(217, 24);
            rad12monthsProduct.Name = "rad12monthsProduct";
            rad12monthsProduct.Size = new Size(100, 28);
            rad12monthsProduct.TabIndex = 2;
            rad12monthsProduct.Text = "12 tháng";
            rad12monthsProduct.UseVisualStyleBackColor = true;
            // 
            // rad30daysProduct
            // 
            rad30daysProduct.AutoSize = true;
            rad30daysProduct.Location = new Point(105, 24);
            rad30daysProduct.Name = "rad30daysProduct";
            rad30daysProduct.Size = new Size(94, 28);
            rad30daysProduct.TabIndex = 1;
            rad30daysProduct.Text = "30 ngày";
            rad30daysProduct.UseVisualStyleBackColor = true;
            // 
            // rad7daysProduct
            // 
            rad7daysProduct.AutoSize = true;
            rad7daysProduct.Checked = true;
            rad7daysProduct.Location = new Point(6, 24);
            rad7daysProduct.Name = "rad7daysProduct";
            rad7daysProduct.Size = new Size(84, 28);
            rad7daysProduct.TabIndex = 0;
            rad7daysProduct.TabStop = true;
            rad7daysProduct.Text = "7 ngày";
            rad7daysProduct.UseVisualStyleBackColor = true;
            // 
            // cbInformationPlus
            // 
            chartArea3.Name = "ChartArea1";
            cbInformationPlus.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            cbInformationPlus.Legends.Add(legend3);
            cbInformationPlus.Location = new Point(6, 229);
            cbInformationPlus.Name = "cbInformationPlus";
            cbInformationPlus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            cbInformationPlus.Series.Add(series4);
            cbInformationPlus.Size = new Size(526, 199);
            cbInformationPlus.TabIndex = 1;
            cbInformationPlus.Text = " ";
            // 
            // gbSales
            // 
            gbSales.BackColor = Color.Aquamarine;
            gbSales.Controls.Add(gbCheckTime);
            gbSales.Controls.Add(chartSales);
            gbSales.Controls.Add(gbImportHistory);
            gbSales.Controls.Add(gbSellingHistory);
            gbSales.Location = new Point(3, 3);
            gbSales.Name = "gbSales";
            gbSales.Size = new Size(800, 705);
            gbSales.TabIndex = 0;
            gbSales.TabStop = false;
            gbSales.Text = "Thống kê doanh thu";
            // 
            // gbCheckTime
            // 
            gbCheckTime.BackColor = Color.Turquoise;
            gbCheckTime.Controls.Add(btnCreateChart);
            gbCheckTime.Controls.Add(rad6months);
            gbCheckTime.Controls.Add(rad5years);
            gbCheckTime.Controls.Add(rad7days);
            gbCheckTime.ForeColor = Color.Black;
            gbCheckTime.Location = new Point(6, 274);
            gbCheckTime.Name = "gbCheckTime";
            gbCheckTime.Size = new Size(788, 58);
            gbCheckTime.TabIndex = 7;
            gbCheckTime.TabStop = false;
            gbCheckTime.Text = "Biểu đồ doanh thu";
            // 
            // btnCreateChart
            // 
            btnCreateChart.Location = new Point(472, 18);
            btnCreateChart.Name = "btnCreateChart";
            btnCreateChart.Size = new Size(304, 34);
            btnCreateChart.TabIndex = 8;
            btnCreateChart.Text = "Tạo biểu đồ";
            btnCreateChart.UseVisualStyleBackColor = true;
            btnCreateChart.Click += btnCreateChart_Click;
            // 
            // rad6months
            // 
            rad6months.AutoSize = true;
            rad6months.Location = new Point(153, 22);
            rad6months.Name = "rad6months";
            rad6months.Size = new Size(90, 28);
            rad6months.TabIndex = 2;
            rad6months.Text = "6 tháng";
            rad6months.UseVisualStyleBackColor = true;
            // 
            // rad5years
            // 
            rad5years.AutoSize = true;
            rad5years.Location = new Point(306, 22);
            rad5years.Name = "rad5years";
            rad5years.Size = new Size(80, 28);
            rad5years.TabIndex = 1;
            rad5years.Text = "5 năm";
            rad5years.UseVisualStyleBackColor = true;
            // 
            // rad7days
            // 
            rad7days.AutoSize = true;
            rad7days.Checked = true;
            rad7days.Location = new Point(6, 22);
            rad7days.Name = "rad7days";
            rad7days.Size = new Size(84, 28);
            rad7days.TabIndex = 0;
            rad7days.TabStop = true;
            rad7days.Text = "7 ngày";
            rad7days.UseVisualStyleBackColor = true;
            // 
            // chartSales
            // 
            chartSales.BorderlineWidth = 4;
            chartArea4.Name = "ChartArea1";
            chartSales.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartSales.Legends.Add(legend4);
            chartSales.Location = new Point(6, 338);
            chartSales.Name = "chartSales";
            chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.BorderWidth = 4;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Thu nhập";
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Chi tiêu";
            chartSales.Series.Add(series5);
            chartSales.Series.Add(series6);
            chartSales.Size = new Size(788, 361);
            chartSales.TabIndex = 5;
            chartSales.Text = "Biểu đồ thu nhập";
            // 
            // gbImportHistory
            // 
            gbImportHistory.BackColor = Color.Turquoise;
            gbImportHistory.Controls.Add(btnReloadImportHistory);
            gbImportHistory.Controls.Add(dgvImportHistory);
            gbImportHistory.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbImportHistory.Location = new Point(406, 26);
            gbImportHistory.Name = "gbImportHistory";
            gbImportHistory.Size = new Size(388, 242);
            gbImportHistory.TabIndex = 3;
            gbImportHistory.TabStop = false;
            gbImportHistory.Text = "Lịch sử nhập hàng";
            // 
            // btnReloadImportHistory
            // 
            btnReloadImportHistory.Location = new Point(6, 198);
            btnReloadImportHistory.Name = "btnReloadImportHistory";
            btnReloadImportHistory.Size = new Size(376, 33);
            btnReloadImportHistory.TabIndex = 2;
            btnReloadImportHistory.Text = "Tải lại";
            btnReloadImportHistory.UseVisualStyleBackColor = true;
            btnReloadImportHistory.Click += btnReloadImportHistory_Click;
            // 
            // dgvImportHistory
            // 
            dgvImportHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImportHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportHistory.Location = new Point(6, 26);
            dgvImportHistory.Name = "dgvImportHistory";
            dgvImportHistory.ReadOnly = true;
            dgvImportHistory.RowHeadersVisible = false;
            dgvImportHistory.Size = new Size(376, 166);
            dgvImportHistory.TabIndex = 0;
            dgvImportHistory.CellClick += dgvImportHistory_CellClick;
            // 
            // gbSellingHistory
            // 
            gbSellingHistory.BackColor = Color.Turquoise;
            gbSellingHistory.Controls.Add(btnReloadSellingHistory);
            gbSellingHistory.Controls.Add(dgvSellingHistory);
            gbSellingHistory.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSellingHistory.Location = new Point(6, 26);
            gbSellingHistory.Name = "gbSellingHistory";
            gbSellingHistory.Size = new Size(394, 242);
            gbSellingHistory.TabIndex = 0;
            gbSellingHistory.TabStop = false;
            gbSellingHistory.Text = "Lịch sử bán hàng";
            // 
            // btnReloadSellingHistory
            // 
            btnReloadSellingHistory.Location = new Point(6, 198);
            btnReloadSellingHistory.Name = "btnReloadSellingHistory";
            btnReloadSellingHistory.Size = new Size(382, 33);
            btnReloadSellingHistory.TabIndex = 2;
            btnReloadSellingHistory.Text = "Tải lại";
            btnReloadSellingHistory.UseVisualStyleBackColor = true;
            btnReloadSellingHistory.Click += btnReloadSellingHistory_Click;
            // 
            // dgvSellingHistory
            // 
            dgvSellingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSellingHistory.Location = new Point(6, 26);
            dgvSellingHistory.Name = "dgvSellingHistory";
            dgvSellingHistory.ReadOnly = true;
            dgvSellingHistory.RowHeadersVisible = false;
            dgvSellingHistory.Size = new Size(382, 166);
            dgvSellingHistory.TabIndex = 0;
            dgvSellingHistory.CellClick += dgvSellingHistory_CellClick;
            // 
            // UCStatistic
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "UCStatistic";
            Size = new Size(1350, 768);
            pnlMain.ResumeLayout(false);
            gbMakeReport.ResumeLayout(false);
            gbChooseReportInfor.ResumeLayout(false);
            gbChooseReportInfor.PerformLayout();
            gbTimeReport.ResumeLayout(false);
            gbTimeReport.PerformLayout();
            groupBox2.ResumeLayout(false);
            gbCheckTypeProductChart.ResumeLayout(false);
            gbCheckTypeProductChart.PerformLayout();
            gbCheckTimeProduct.ResumeLayout(false);
            gbCheckTimeProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbInformationPlus).EndInit();
            gbSales.ResumeLayout(false);
            gbCheckTime.ResumeLayout(false);
            gbCheckTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartSales).EndInit();
            gbImportHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImportHistory).EndInit();
            gbSellingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSellingHistory).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.GroupBox gbMakeReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbSellingHistory;
        private System.Windows.Forms.Button btnCreateChart;
        private System.Windows.Forms.GroupBox gbCheckTime;
        private System.Windows.Forms.RadioButton rad6months;
        private System.Windows.Forms.RadioButton rad5years;
        private System.Windows.Forms.RadioButton rad7days;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.GroupBox gbImportHistory;
        private System.Windows.Forms.Button btnReloadImportHistory;
        private System.Windows.Forms.DataGridView dgvImportHistory;
        private System.Windows.Forms.Button btnReloadSellingHistory;
        private System.Windows.Forms.DataGridView dgvSellingHistory;
        private System.Windows.Forms.DataVisualization.Charting.Chart cbInformationPlus;
        private System.Windows.Forms.GroupBox gbCheckTypeProductChart;
        private System.Windows.Forms.GroupBox gbCheckTimeProduct;
        private System.Windows.Forms.RadioButton rad12monthsProduct;
        private System.Windows.Forms.RadioButton rad30daysProduct;
        private System.Windows.Forms.RadioButton rad7daysProduct;
        private System.Windows.Forms.ComboBox cbTypeChartProduct;
        private System.Windows.Forms.Button btnMakeChartProduct;
        private System.Windows.Forms.GroupBox gbChooseReportInfor;
        private System.Windows.Forms.CheckBox chbReportImport;
        private System.Windows.Forms.CheckBox chbReportOrder;
        private System.Windows.Forms.CheckBox chbReportAll;
        private System.Windows.Forms.CheckBox chbReportSpending;
        private System.Windows.Forms.CheckBox chbReportIncome;
        private System.Windows.Forms.GroupBox gbTimeReport;
        private System.Windows.Forms.RadioButton radReportAll;
        private System.Windows.Forms.RadioButton radReport1year;
        private System.Windows.Forms.RadioButton radReport3months;
        private System.Windows.Forms.RadioButton radReport30days;
        private System.Windows.Forms.RadioButton radReport7days;
        private System.Windows.Forms.RadioButton radReportToday;
        private System.Windows.Forms.Button btnOutputReport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbReportStaff;
        private System.Windows.Forms.CheckBox chbReportSupplier;
        private System.Windows.Forms.CheckBox chbReportProduct;
    }
}
