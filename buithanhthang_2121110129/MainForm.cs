using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Enum;
using buithanhthang_2121110129.UserControl;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace buithanhthang_2121110129
{
    public partial class MainForm : Form
    {
        public static Action LoadData;
        public static Staff staff_using;

        public MainForm()
        {
            InitializeComponent();

            cbMenu.Items.Add("TRANG CHỦ");
            cbMenu.Items.Add("SẢN PHẨM");
            cbMenu.Items.Add("BÁN HÀNG");
            cbMenu.Items.Add("NHẬP HÀNG");
            cbMenu.Items.Add("THỐNG KÊ");
            cbMenu.Items.Add("NHÂN VIÊN");
            cbMenu.SelectedIndex = 0;

            cbSetting.DataSource = new BindingSource(settingText, null);
            cbSetting.DisplayMember = "Value";
            cbSetting.ValueMember = "Key";

            AddTabToControl();
            SettingCallForLoadData();

            LoadData.Invoke();

            timer.Start();
        }

        #region MoveForm
        private Point firstPoint;
        private bool mouseIsDown = false;

        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }
        private void pnlMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
        private void pnlMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
        #endregion

        private void ShowTabUsing(string tabName)
        {
            lblTabShow.Text = $"Tab đang hiển thị: {tabName}";
        }

        private void AddTabToControl()
        {
            pnlMain.Controls.Add(UCHomePage.Instance);
            pnlMain.Controls.Add(UCImported.Instance);
            pnlMain.Controls.Add(UCOrdered.Instance);
            pnlMain.Controls.Add(UCProduct.Instance);
            pnlMain.Controls.Add(UCStatistic.Instance);
            pnlMain.Controls.Add(UCStaff.Instance);

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


        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        private Dictionary<SettingControl, string> settingText =
            new Dictionary<SettingControl, string>()
        {
            { SettingControl.LOGIN, "Đăng nhập" },
            { SettingControl.LOGOUT, "Đăng xuất" },
            { SettingControl.SUPPORT, "Hỗ trợ" },
            { SettingControl.INFORMATION, "Thông tin" },
            { SettingControl.EXIT, "Thoát" }
        };

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
                        if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            staff_using = null;
                            UCHomePage.Instance.LoadStaffData(staff_using); // Xóa thông tin nhân viên trên Home

                            // Đóng MainForm và mở lại FormLogin
                            this.Hide(); // Ẩn MainForm trước
                            new FormLogin().ShowDialog(); // Mở FormLogin (modal)

                            // Nếu người dùng đăng nhập lại thành công → hiện MainForm
                            if (staff_using != null)
                            {
                                UCHomePage.Instance.LoadStaffData(staff_using);
                                this.Show();
                            }
                            else
                            {
                                // Nếu bấm thoát ở FormLogin → đóng hẳn ứng dụng
                                Application.Exit();
                            }
                        }
                        break;
                    }
                case SettingControl.SUPPORT:
                    {
                        break;
                    }
                case SettingControl.INFORMATION:
                    {
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
        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMenu.SelectedIndex)
            {
                case 0:
                    ShowTabUsing("TRANG CHỦ");
                    UCHomePage.Instance.BringToFront();
                    break;
                case 1:
                    ShowTabUsing("SẢN PHẨM");
                    UCProduct.Instance.BringToFront();
                    break;
                case 2:
                    ShowTabUsing("BÁN HÀNG");
                    UCOrdered.Instance.BringToFront();
                    break;
                case 3:
                    ShowTabUsing("NHẬP HÀNG");
                    UCImported.Instance.BringToFront();
                    break;
                case 4:
                    ShowTabUsing("THỐNG KÊ");
                    UCStatistic.Instance.BringToFront();
                    break;
                case 5:
                    ShowTabUsing("NHÂN VIÊN");
                    UCStaff.Instance.BringToFront();
                    break;
            }
        }
    }
}