using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Enum;
using buithanhthang_2121110129.UserControl;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace buithanhthang_2121110129
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private bool isDarkMode = true;
        // Danh sách tất cả button menu để dễ quản lý highlight
        private List<Button> menuButtons;
        public static Action LoadData;
        public static Staff staff_using;

        public MainForm()
        {
            InitializeComponent();
            cbSetting.DataSource = Enum.GetValues(typeof(SettingControl));

            InitializeMenuButtons();
            ApplyCustomStyle();
            AddTabToControl();
            SettingCallForLoadData();

            LoadData.Invoke();

            timer.Start();
        }

        private void ApplyCustomStyle()
        {
            ApplyDarkMode();

            // Kéo form
            this.pnlMove.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0xA1, 0x2, 0);
                }
            };

            btnMaximize.Click += (s, e) =>
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    btnMaximize.Text = "❐"; // Icon restore
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMaximize.Text = "☐"; // Icon maximize
                }
            };
            btnMaximize.MouseEnter += (s, e) => btnMaximize.BackColor = Color.FromArgb(60, 60, 60);
            btnMaximize.MouseLeave += (s, e) => btnMaximize.BackColor = Color.Transparent;

            btnThemeToggle.Click += BtnThemeToggle_Click;
            // Style chung cho button menu
            StyleAllMenuButtons();

            // Nút minimize & close
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.MouseEnter += (s, e) => btnMinimize.BackColor = Color.FromArgb(60, 60, 60);
            btnMinimize.MouseLeave += (s, e) => btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.ForeColor = Color.White;
            btnClose.MouseEnter += (s, e) => btnClose.BackColor = Color.Red;
            btnClose.MouseLeave += (s, e) => btnClose.BackColor = Color.Transparent;
            btnClose.Click += (s, e) => this.Close();

            // Timer hiển thị giờ
            timer.Interval = 1000;
            timer.Start();
        }

        private void InitializeMenuButtons()
        {
            menuButtons = new List<Button>
            {
                btnHomePage,
                btnProduct,
                btnOrder,
                btnImport,
                btnStatistic,
                btnStaff,
            };

            // Gán sự kiện Click cho từng button
            btnHomePage.Click += (s, e) => SelectMenuButton(btnHomePage, "Trang chủ");
            btnProduct.Click += (s, e) => SelectMenuButton(btnProduct, "Sản phẩm");
            btnOrder.Click += (s, e) => SelectMenuButton(btnOrder, "Bán hàng");
            btnImport.Click += (s, e) => SelectMenuButton(btnImport, "Nhập hàng");
            btnStatistic.Click += (s, e) => SelectMenuButton(btnStatistic, "Thống kê");
            btnStaff.Click += (s, e) => SelectMenuButton(btnStaff, "Nhân viên");

            // Mặc định chọn Trang chủ
            SelectMenuButton(btnHomePage, "Trang chủ");
        }

        private void StyleAllMenuButtons()
        {
            foreach (Button btn in menuButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(20, 0, 0, 0);

                // Hover effect
                btn.MouseEnter += (s, e) =>
                {
                    if (btn.BackColor != Color.FromArgb(0, 120, 215)) // Không override nếu đang selected
                        btn.BackColor = Color.FromArgb(0, 140, 255);
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (btn.BackColor != Color.FromArgb(0, 120, 215))
                        btn.BackColor = Color.Transparent;
                };
            }
        }

        private void SelectMenuButton(Button selectedButton, string tabName)
        {
            // Tắt highlight tất cả button
            foreach (Button btn in menuButtons)
            {
                btn.BackColor = Color.Transparent;
            }

            // Bật highlight cho button được chọn
            selectedButton.BackColor = Color.FromArgb(0, 120, 215);

            // Cập nhật nhãn tab đang hiển thị
            //lblTabShow.Text = "Tab đang hiển thị: " + tabName;

            // Ở đây bạn sẽ load form con tương ứng vào pnlMain
            // Ví dụ:
            // LoadFormIntoPanel(new FormSanPham());
            // LoadFormIntoPanel(new FormBanHang());
        }
        private void ShowTabUsing(string tabName)
        {
            lblTabShow.Text = $"Tab đang hiển thị: {tabName}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss");
            lblTime.ForeColor = Color.LightGray;
            lblTime.Font = new Font("Segoe UI", 10F);
        }

        private void BtnThemeToggle_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            if (isDarkMode)
            {
                ApplyDarkMode();
                btnThemeToggle.Text = "☀ Light";
            }
            else
            {
                ApplyLightMode();
                btnThemeToggle.Text = "🌙 Dark";
            }
        }

        private void ApplyDarkMode()
        {
            this.pnlMove.BackColor = Color.FromArgb(30, 30, 30);
            this.pnlControl.BackColor = Color.FromArgb(35, 35, 40);
            this.pnlMain.BackColor = Color.FromArgb(45, 45, 48);
            this.BackColor = Color.FromArgb(30, 30, 30);

            lblAppTitle.ForeColor = Color.White;
            lblTabShow.ForeColor = Color.LightGray;
            lblTime.ForeColor = Color.LightGray;
        }

        private void ApplyLightMode()
        {
            this.pnlMove.BackColor = Color.FromArgb(240, 240, 240);
            this.pnlControl.BackColor = Color.FromArgb(255, 255, 255);
            this.pnlMain.BackColor = Color.FromArgb(250, 250, 250);
            this.BackColor = Color.FromArgb(245, 245, 245);

            lblAppTitle.ForeColor = Color.Black;
            lblTabShow.ForeColor = Color.Gray;
            lblTime.ForeColor = Color.DarkGray;

            foreach (Button btn in menuButtons)
            {
                btn.ForeColor = Color.Black;
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnHomePage.Text);
            UCHomePage.Instance.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnProduct.Text);
            UCProduct.Instance.BringToFront();
        }
        private void AddTabToControl()
        {
            pnlMain.Controls.Add(UCHomePage.Instance);
            pnlMain.Controls.Add(UCImported.Instance);
            pnlMain.Controls.Add(UCOrdered.Instance);
            pnlMain.Controls.Add(UCProduct.Instance);
            pnlMain.Controls.Add(UCStatistic.Instance);
            pnlMain.Controls.Add(UCStaff.Instance);

            ShowTabUsing(btnHomePage.Text);
        }

        private static void SettingCallForLoadData()
        {
            LoadData = UCProduct.Instance.LoadData;
            LoadData += UCImported.Instance.LoadData;
            LoadData += UCOrdered.Instance.LoadData;
        }

        #region TabControl
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnStaff.Text);
            UCStaff.Instance.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnOrder.Text);
            UCOrdered.Instance.BringToFront();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnImport.Text);
            UCImported.Instance.BringToFront();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnStatistic.Text);
            UCStatistic.Instance.BringToFront();
        }

        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        private void cbSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((SettingControl)cbSetting.SelectedIndex)
            {
                case SettingControl.LOGIN:
                    {
                        if (staff_using == null)
                        {
                            new FormLogin().ShowDialog();
                            UCHomePage.Instance.LoadStaffData(staff_using);
                        }
                        break;
                    }
                case SettingControl.LOGOUT:
                    {
                        if (staff_using == null)
                            return;

                        if (MessageBox.Show("Bạn có muốn kết thúc phiên đăng nhập không?", "THÔNG BÁO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            staff_using = null;
                            UCHomePage.Instance.LoadStaffData(staff_using);
                        }
                        break;
                    }
                case SettingControl.SUPPORT:
                    {
                        break;
                    }
                case SettingControl.INFORMATION:
                    {
                        MessageBox.Show(@"Chào!");
                        break;
                    }
                case SettingControl.EXIT:
                    {
                        if (MessageBox.Show("Bạn có muốn tắt ứng dụng không?", "THÔNG BÁO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        break;
                    }
            }
        }
    }
}