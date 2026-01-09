using buithanhthang_2121110129.BusinessLogicLayer;
using buithanhthang_2121110129.DataAccessLayer;
using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Enum;
using buithanhthang_2121110129.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129.UserControl
{
    public partial class UCHomePage : System.Windows.Forms.UserControl
    {
        private BUS_Customer bus_customer;
        private BUS_Imported bus_imported;
        private BUS_Ordered bus_ordered;
        private BUS_ProductStatistic bus_productStat;

        private Dictionary<string, string> link;

        static UCHomePage _obj;
        public static UCHomePage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCHomePage();
                }
                return _obj;
            }
        }
        public UCHomePage()
        {
            InitializeComponent();

            link = new Dictionary<string, string>();

            bus_customer = new BUS_Customer();
            bus_imported = new BUS_Imported();
            bus_ordered = new BUS_Ordered();
            bus_productStat = new BUS_ProductStatistic();

            Task.Run(() => LoadStoreInformation());
            LoadCustomerData();
            LoadProductChart();           // ← Gọi load biểu đồ
            LoadNewImportedProducts();    // ← Gọi load danh sách sản phẩm mới nhập
        }


        #region ButtonControl
        private void btnChangeCustomerInfor_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
                return;

            new FormCustomer(new Customer(
                name: txtCustomerName.Text,
                phone: txtCustomerPhone.Text,
                dateJoin: dtCustomerDateJoin.Value,
                value: float.Parse(txtCustomerValue.Text),
                e_level: dgvCustomer.CurrentRow.Cells[4].Value.ToString())).ShowDialog();
        }

        private void btnChangeStoreInfor_Click(object sender, EventArgs e)
        {
            new FormStoreInfomation().ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new FormCustomer().ShowDialog();
        }

        private void btnReloadValue_Click(object sender, EventArgs e)
        {
            LoadIncomeData();
            LoadProductChart();           // ← reload biểu đồ
            LoadNewImportedProducts();    // ← reload listbox
        }
        #endregion

        #region PictureBox_Link

        private void picYoutube_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["youtube"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["facebook"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picInsta_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["instagram"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picLinkedIn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["linkedin"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picStoreLocation_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["map"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictContact_Click(object sender, EventArgs e)
        {

        }
        #endregion


        public void LoadStoreInformation()
        {
            DAO_Information dao = new DAO_Information("StoreInformation.xml");
            Dictionary<string, string> data = dao.LoadStoreInformation();

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ApplyStoreInfo(data)));
            }
            else
            {
                ApplyStoreInfo(data);
            }
        }

        private void ApplyStoreInfo(Dictionary<string, string> data)
        {
            lblAddress.Text = "Địa chỉ: " + data["address"];
            lblAddress.MaximumSize = new Size(600, 0);
            lblAddress.AutoSize = true;

            lblEmail.Text = "Email: " + data["email"];
            lblPhone.Text = "Số điện thoại: " + data["phone"];

            link.Clear();
            link["map"] = data["link_map"];
            link["facebook"] = data["link_fb"];
            link["instagram"] = data["link_ig"];
            link["linkedin"] = data["link_linkedin"];
            link["youtube"] = data["link_ut"];
        }

        public void LoadCustomerData()
        {
            dgvCustomer.DataSource = bus_customer.GetAllCustomer();
        }

        /// <summary>
        /// Setting staff data to form
        /// </summary>
        /// <param name="staff"></param>
        public void LoadStaffData(Staff staff)
        {
            if (staff != null)
            {
                lblYourName.Text = $"Họ tên: {staff.Name}";
                lblYourGender.Text = $"Giới tính: {staff.Gender}";
                lblYourEmail.Text = $"Email: {staff.Email}";
                lblYourPhone.Text = $"Số điện thoại: {staff.Phone}";
                picStaff.Image = staff.Images;
            }
            else
            {
                lblYourName.Text = "Họ tên: ";
                lblYourGender.Text = "Giới tính: ";
                lblYourEmail.Text = "Email: ";
                lblYourPhone.Text = "Số điện thoại: ";
                picStaff.Image = null;
            }
        }

        private void LoadProductChart()
        {
            // Lấy dữ liệu phần trăm sản phẩm bán ra theo tên trong 30 ngày gần nhất
            DateTime toDate = DateTime.Today;
            DateTime fromDate = toDate.AddDays(-29);

            var saleData = bus_productStat.GetSalePercentByProductName(fromDate, toDate);

            // Xóa dữ liệu cũ
            chartProduct.Series["Series1"].Points.Clear();
            chartProduct.Titles.Clear();
            chartProduct.Titles.Add("Top sản phẩm bán chạy (30 ngày gần nhất)");

            if (saleData.Count == 0)
            {
                chartProduct.Titles.Add("Chưa có dữ liệu bán hàng");
                return;
            }

            // Chỉ lấy top 8 sản phẩm để biểu đồ đẹp
            var topProducts = saleData.OrderByDescending(x => x.Value).Take(8).ToList();

            foreach (var item in topProducts)
            {
                var point = chartProduct.Series["Series1"].Points.Add(item.Value);
                point.AxisLabel = item.Key;
                point.Label = $"{item.Value}%";
                point.LegendText = item.Key;
            }

            // Tùy chỉnh đẹp hơn
            chartProduct.Series["Series1"]["PieLabelStyle"] = "Outside";
            chartProduct.Series["Series1"]["PieLineColor"] = "Black";
            chartProduct.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        }

        private void LoadNewImportedProducts()
        {
            // Lấy dữ liệu nhập hàng trong 7 ngày gần nhất
            DateTime toDate = DateTime.Today.AddDays(1); // bao gồm hôm nay
            DateTime fromDate = toDate.AddDays(-7);

            // Giả sử bạn có DAO_Bill_Item với phương thức GetAllItemsInPeriod đã có (từ BUS_ProductStatistic)
            // Ta sẽ lấy trực tiếp từ BUS_ProductStatistic hoặc tạo query đơn giản

            // Cách đơn giản: lấy tất cả sản phẩm nhập trong 7 ngày gần nhất
            DataTable importedItems = null;
            try
            {
                // Nếu DAO_Bill_Item có phương thức GetAllItemsInPeriod
                importedItems = new DAO_Bill_Item("Imported").GetAllItemsInPeriod(fromDate, toDate);
            }
            catch
            {
                listBoxProductNewImport.Items.Add("Không tải được dữ liệu nhập hàng");
                return;
            }

            listBoxProductNewImport.Items.Clear();

            if (importedItems.Rows.Count == 0)
            {
                listBoxProductNewImport.Items.Add("Không có sản phẩm mới nhập trong 7 ngày qua");
                return;
            }

            listBoxProductNewImport.Items.Add("=== Sản phẩm mới nhập (7 ngày gần nhất) ===");

            // Group theo tên sản phẩm để hiển thị đẹp
            var grouped = importedItems.AsEnumerable()
                .GroupBy(row => row["ProductName"].ToString())
                .Select(g => new
                {
                    Name = g.Key,
                    TotalQty = g.Sum(r => Convert.ToInt32(r["Quantity"]))
                })
                .OrderByDescending(x => x.TotalQty);

            foreach (var item in grouped)
            {
                listBoxProductNewImport.Items.Add($"{item.Name} - Nhập {item.TotalQty} cái");
            }
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.CurrentCell.RowIndex == dgvCustomer.RowCount - 1)
                return;

            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtCustomerPhone.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            dtCustomerDateJoin.Value = (DateTime)dgvCustomer.CurrentRow.Cells[2].Value;
            txtCustomerValue.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            picCustomerLevel.BackgroundImage = LoadLevelCustomer(dgvCustomer.CurrentRow.Cells[4].Value.ToString());
        }

        public void LoadIncomeData()
        {
            double income_day = bus_ordered.GetValueOfAllBills_Day(DateTime.Today).Value;
            txtIncomeDay.Text = GetFormatString.GetCurrencyString(income_day);
            double income = bus_ordered.GetValueOfAllBills().Value; // Thu nhap
            txtTotalIncome.Text = GetFormatString.GetCurrencyString(income);

            double spending_day = bus_imported.GetValueOfAllBills_Day(DateTime.Today).Value;
            txtSpendingDay.Text = GetFormatString.GetCurrencyString(spending_day);
            double spending = bus_imported.GetValueOfAllBills().Value; // Chi tra
            txtTotalSpending.Text = GetFormatString.GetCurrencyString(spending);


            txtProfit.Text = ((income - spending) / spending * 100).ToString("N3") + " %";
        }

        /// <summary>
        /// Show image of customer's level
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        //private Image LoadLevelCustomer(string level)
        //{
        //    string path = Path.GetDirectoryName(Directory.GetCurrentDirectory());
        //    path = path.Replace("bin", "Resources/") + level.Trim() + ".png";
        //    return Image.FromFile(path);
        //}
        private Image LoadLevelCustomer(string level)
        {
            if (!System.Enum.TryParse(level, true, out Level customerLevel))
                return Properties.Resources.None;

            return customerLevel switch
            {
                Level.Copper => Properties.Resources.Copper,
                Level.Silver => Properties.Resources.Silver,
                Level.Golden => Properties.Resources.Golden,
                Level.Platinum => Properties.Resources.Platinum,
                _ => Properties.Resources.None
            };
        }

        private void btnReloadCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
    }
}
