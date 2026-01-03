namespace buithanhthang_2121110129
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlContainer = new Panel();
            pnlMain = new Panel();
            pnlControl = new Panel();
            btnHomePage = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            btnImport = new Button();
            btnStatistic = new Button();
            btnStaff = new Button();
            pnlMove = new Panel();
            btnMinimize = new Button();
            lblAppTitle = new Label();
            lblTabShow = new Label();
            cbSetting = new ComboBox();
            btnClose = new Button();
            btnMaximize = new Button();
            btnThemeToggle = new Button();
            lblTime = new Label();
            monthCalendar1 = new MonthCalendar();
            timer = new System.Windows.Forms.Timer(components);
            pnlContainer.SuspendLayout();
            pnlControl.SuspendLayout();
            pnlMove.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(pnlMain);
            pnlContainer.Controls.Add(pnlControl);
            pnlContainer.Controls.Add(pnlMove);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1366, 768);
            pnlContainer.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(148, 50);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1218, 718);
            pnlMain.TabIndex = 2;
            // 
            // pnlControl
            // 
            pnlControl.BackColor = Color.Gold;
            pnlControl.Controls.Add(btnHomePage);
            pnlControl.Controls.Add(btnProduct);
            pnlControl.Controls.Add(btnOrder);
            pnlControl.Controls.Add(btnImport);
            pnlControl.Controls.Add(btnStatistic);
            pnlControl.Controls.Add(btnStaff);
            pnlControl.Location = new Point(0, 50);
            pnlControl.Name = "pnlControl";
            pnlControl.Size = new Size(149, 718);
            pnlControl.TabIndex = 1;
            // 
            // btnHomePage
            // 
            btnHomePage.Image = Properties.Resources.icons8_home_32;
            btnHomePage.Location = new Point(0, 20);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(148, 60);
            btnHomePage.TabIndex = 0;
            btnHomePage.Text = "  TRANG CHỦ";
            btnHomePage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // btnProduct
            // 
            btnProduct.Image = Properties.Resources.icons8_product_32;
            btnProduct.Location = new Point(0, 90);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(148, 60);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "  SẢN PHẨM";
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.Image = Properties.Resources.icons8_purchase_order_32;
            btnOrder.Location = new Point(0, 160);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(148, 60);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "  BÁN HÀNG";
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Image = Properties.Resources.icons8_import_32;
            btnImport.Location = new Point(0, 230);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(148, 60);
            btnImport.TabIndex = 3;
            btnImport.Text = "  NHẬP HÀNG";
            btnImport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImport.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            btnStatistic.Image = Properties.Resources.icons8_plot_32;
            btnStatistic.Location = new Point(0, 300);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(148, 60);
            btnStatistic.TabIndex = 4;
            btnStatistic.Text = "  THỐNG KÊ";
            btnStatistic.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.Image = Properties.Resources.icons8_staff_32;
            btnStaff.Location = new Point(0, 370);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(148, 60);
            btnStaff.TabIndex = 5;
            btnStaff.Text = "  NHÂN VIÊN";
            btnStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStaff.UseVisualStyleBackColor = true;
            // 
            // pnlMove
            // 
            pnlMove.BackColor = Color.FromArgb(30, 30, 30);
            pnlMove.Controls.Add(btnMinimize);
            pnlMove.Controls.Add(lblAppTitle);
            pnlMove.Controls.Add(lblTabShow);
            pnlMove.Controls.Add(cbSetting);
            pnlMove.Controls.Add(btnClose);
            pnlMove.Controls.Add(btnMaximize);
            pnlMove.Controls.Add(btnThemeToggle);
            pnlMove.Controls.Add(lblTime);
            pnlMove.Location = new Point(0, 0);
            pnlMove.Name = "pnlMove";
            pnlMove.Size = new Size(1366, 50);
            pnlMove.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Font = new Font("Segoe UI", 18F);
            btnMinimize.Location = new Point(1216, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 50);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "–";
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(20, 12);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(227, 25);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "QUẢN LÝ SIÊU THỊ MINI";
            // 
            // lblTabShow
            // 
            lblTabShow.AutoSize = true;
            lblTabShow.ForeColor = Color.White;
            lblTabShow.Location = new Point(300, 18);
            lblTabShow.Name = "lblTabShow";
            lblTabShow.Size = new Size(158, 15);
            lblTabShow.TabIndex = 1;
            lblTabShow.Text = "Tab đang hiển thị: Trang chủ";
            // 
            // cbSetting
            // 
            cbSetting.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSetting.Location = new Point(898, 10);
            cbSetting.Name = "cbSetting";
            cbSetting.Size = new Size(200, 23);
            cbSetting.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 20F);
            btnClose.Location = new Point(1316, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 0;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            btnMaximize.Font = new Font("Segoe UI", 16F);
            btnMaximize.Location = new Point(1266, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(50, 50);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "☐";
            btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnThemeToggle
            // 
            btnThemeToggle.BackColor = Color.Transparent;
            btnThemeToggle.FlatAppearance.BorderSize = 0;
            btnThemeToggle.FlatStyle = FlatStyle.Flat;
            btnThemeToggle.Font = new Font("Segoe UI", 12F);
            btnThemeToggle.ForeColor = Color.White;
            btnThemeToggle.Location = new Point(1110, 6);
            btnThemeToggle.Name = "btnThemeToggle";
            btnThemeToggle.Size = new Size(100, 34);
            btnThemeToggle.TabIndex = 4;
            btnThemeToggle.Text = "☀ Light";
            btnThemeToggle.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(480, 18);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 19);
            lblTime.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // MainForm
            // 
            ClientSize = new Size(1366, 768);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Siêu Thị Mini";
            pnlContainer.ResumeLayout(false);
            pnlControl.ResumeLayout(false);
            pnlMove.ResumeLayout(false);
            pnlMove.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbSetting;
        private System.Windows.Forms.Timer timer;
        private Button btnMaximize;
        private Button btnThemeToggle;
    }
}