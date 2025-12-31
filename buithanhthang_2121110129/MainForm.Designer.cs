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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblTabShow = new System.Windows.Forms.Label();
            this.cbSetting = new System.Windows.Forms.ComboBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);

            this.pnlContainer.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlMove.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1366, 768);
            this.pnlContainer.TabIndex = 0;

            // 
            // pnlMove (Title bar)
            // 
            this.pnlMove.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(1366, 50);
            this.pnlMove.TabIndex = 0;

            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 12);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Text = "QUẢN LÝ SIÊU THỊ MINI";

            // 
            // lblTabShow
            // 
            this.lblTabShow.AutoSize = true;
            this.lblTabShow.ForeColor = System.Drawing.Color.LightGray;
            this.lblTabShow.Location = new System.Drawing.Point(300, 18);
            this.lblTabShow.Name = "lblTabShow";
            this.lblTabShow.Text = "Tab đang hiển thị: Trang chủ";

            // 
            // cbSetting
            // 
            this.cbSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetting.Location = new System.Drawing.Point(950, 12);
            this.cbSetting.Name = "cbSetting";
            this.cbSetting.Size = new System.Drawing.Size(200, 28);
            this.cbSetting.TabIndex = 3;

            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(1266, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "–";
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnMinimize.UseVisualStyleBackColor = true;

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1316, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "×";
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // pnlControl (Sidebar)
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Gold; // Sẽ đổi trong code-behind
            this.pnlControl.Location = new System.Drawing.Point(0, 50);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(260, 718);
            this.pnlControl.TabIndex = 1;

            // 
            // Các button menu
            // 
            this.btnHomePage.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_home_32;
            this.btnHomePage.Location = new System.Drawing.Point(0, 20);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(260, 60);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "  TRANG CHỦ";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;

            

            this.btnProduct.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_product_32;
            this.btnProduct.Location = new System.Drawing.Point(0, 90);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(260, 60);
            this.btnProduct.Text = "  SẢN PHẨM";

            this.btnOrder.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_purchase_order_32;
            this.btnOrder.Location = new System.Drawing.Point(0, 160);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(260, 60);
            this.btnOrder.Text = "  BÁN HÀNG";

            this.btnImport.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_import_32;
            this.btnImport.Location = new System.Drawing.Point(0, 230);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(260, 60);
            this.btnImport.Text = "  NHẬP HÀNG";

            this.btnStatistic.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_plot_32;
            this.btnStatistic.Location = new System.Drawing.Point(0, 300);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(260, 60);
            this.btnStatistic.Text = "  THỐNG KÊ";

            this.btnStaff.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_staff_32;
            this.btnStaff.Location = new System.Drawing.Point(0, 370);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(260, 60);
            this.btnStaff.Text = "  NHÂN VIÊN";

            this.btnCalendar.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_Tear_Off_Calendar_32;
            this.btnCalendar.Location = new System.Drawing.Point(0, 440);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(260, 60);
            this.btnCalendar.Text = "  LỊCH BIỂU";

            this.btnBrowser.Image = global::buithanhthang_2121110129.Properties.Resources.icons8_mint_browser_32;
            this.btnBrowser.Location = new System.Drawing.Point(0, 510);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(260, 60);
            this.btnBrowser.Text = "  TRÌNH DUYỆT";

            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 680);
            this.lblTime.Name = "lblTime";

            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(260, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1106, 718);
            this.pnlMain.TabIndex = 2;

            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);

            // 
            // Add controls
            // 
            this.pnlMove.Controls.Add(this.lblAppTitle);
            this.pnlMove.Controls.Add(this.lblTabShow);
            this.pnlMove.Controls.Add(this.cbSetting);
            this.pnlMove.Controls.Add(this.btnMinimize);
            this.pnlMove.Controls.Add(this.btnClose);

            this.pnlControl.Controls.Add(this.btnHomePage);
            this.pnlControl.Controls.Add(this.btnProduct);
            this.pnlControl.Controls.Add(this.btnOrder);
            this.pnlControl.Controls.Add(this.btnImport);
            this.pnlControl.Controls.Add(this.btnStatistic);
            this.pnlControl.Controls.Add(this.btnStaff);
            this.pnlControl.Controls.Add(this.btnCalendar);
            this.pnlControl.Controls.Add(this.btnBrowser);
            this.pnlControl.Controls.Add(this.lblTime);

            this.pnlContainer.Controls.Add(this.pnlMain);
            this.pnlContainer.Controls.Add(this.pnlControl);
            this.pnlContainer.Controls.Add(this.pnlMove);

            this.Controls.Add(this.pnlContainer);
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Siêu Thị Mini";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

            this.pnlContainer.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbSetting;
        private System.Windows.Forms.Timer timer;
    }
}