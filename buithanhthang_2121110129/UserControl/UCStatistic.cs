using buithanhthang_2121110129.BusinessLogicLayer;
using buithanhthang_2121110129.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129.UserControl
{
    public partial class UCStatistic : System.Windows.Forms.UserControl
    {
        private BUS_Imported bus_imported;
        private BUS_Ordered bus_ordered;
        private BUS_ProductStatistic bus_productStat;
        private BUS_Product bus_product; // để lấy danh sách tên sản phẩm

        static UCStatistic _obj;
        public static UCStatistic Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCStatistic();
                }
                return _obj;
            }
        }
        public UCStatistic()
        {
            InitializeComponent();

            bus_imported = new BUS_Imported();
            bus_ordered = new BUS_Ordered();
            bus_productStat = new BUS_ProductStatistic();
            bus_product = new BUS_Product();

            LoadData();
            LoadProductNamesToComboBox();
        }

        private void LoadData()
        {
            dgvSellingHistory.Controls.Clear();
            dgvSellingHistory.DataSource = bus_ordered.GetAllBill();
            dgvSellingHistory.Columns[0].Visible = false;

            dgvImportHistory.Controls.Clear();
            dgvImportHistory.DataSource = bus_imported.GetAllBill();
            dgvImportHistory.Columns[0].Visible = false;
        }
        private void LoadProductNamesToComboBox()
        {
            DataTable dt = bus_product.GetAllProduct();
            comboBox1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["Name"].ToString());
            }
        }
        private void cbTypeChartProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ hiện comboBox1 khi chọn "Doanh số sản phẩm bán ra tùy chọn" (index 4)
            bool isRevenueChart = cbTypeChartProduct.SelectedIndex == 4;
            label1.Visible = isRevenueChart;
            comboBox1.Visible = isRevenueChart;

            if (isRevenueChart && comboBox1.Items.Count == 0)
            {
                LoadProductNamesToComboBox();
            }
        }
        private void radReportToday_CheckedChanged(object sender, EventArgs e)
        {
            chbReportIncome.Enabled = chbReportIncome.Checked = !radReportToday.Checked;
            chbReportSpending.Enabled = chbReportSpending.Checked = !radReportToday.Checked;
        }

        private void btnReloadSellingHistory_Click(object sender, EventArgs e)
        {
            dgvSellingHistory.Controls.Clear();
            dgvSellingHistory.DataSource = bus_ordered.GetAllBill();
            dgvSellingHistory.Columns[0].Visible = false;
        }

        private void btnReloadImportHistory_Click(object sender, EventArgs e)
        {
            dgvImportHistory.Controls.Clear();
            dgvImportHistory.DataSource = bus_imported.GetAllBill();
            dgvImportHistory.Columns[0].Visible = false;
        }

        private void btnCreateChart_Click(object sender, EventArgs e)
        {
            chartSales.Series["Thu nhập"].Points.Clear();
            chartSales.Series["Chi tiêu"].Points.Clear();

            if (rad7days.Checked)
            {
                DateTime now = DateTime.Today;
                DateTime last = now.AddDays(-6);

                for (DateTime date = last; date <= now; date = date.AddDays(1))
                {
                    double spending = bus_imported.GetValueOfAllBills_Day(date).Value;
                    chartSales.Series["Chi tiêu"].Points.AddXY(date.Day + "-" + date.Month, spending / 1000);

                    double income = bus_ordered.GetValueOfAllBills_Day(date).Value;
                    chartSales.Series["Thu nhập"].Points.AddXY(date.Day + "-" + date.Month, income / 1000);
                }
            }
            else if (rad6months.Checked)
            {
                DateTime now = DateTime.Today;
                DateTime last = now.AddMonths(-5);

                for (DateTime date = last; date <= now; date = date.AddMonths(1))
                {
                    double spending = bus_imported.GetValueOfAllBills_Month(date).Value;
                    chartSales.Series["Chi tiêu"].Points.AddXY(date.Month + "-" + date.Year, spending / 1000000);

                    double income = bus_ordered.GetValueOfAllBills_Month(date).Value;
                    chartSales.Series["Thu nhập"].Points.AddXY(date.Month + "-" + date.Year, income / 1000000);
                }
            }
            else if (rad5years.Checked)
            {
                DateTime now = DateTime.Today;
                DateTime last = now.AddYears(-4);

                for (DateTime date = last; date <= now; date = date.AddYears(1))
                {
                    double spending = 0, income = 0;
                    for (int i = 1; i <= 12; i++)
                    {
                        DateTime new_date = new DateTime(date.Year, i, 1);

                        spending += bus_imported.GetValueOfAllBills_Month(new_date).Value;
                        income += bus_ordered.GetValueOfAllBills_Month(new_date).Value;
                    }
                    chartSales.Series["Chi tiêu"].Points.AddXY(date.Year, spending / 1000000);
                    chartSales.Series["Thu nhập"].Points.AddXY(date.Year, income / 1000000);
                }
            }
        }

        private void dgvSellingHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ordered bill = new Ordered();
            bill.ID = dgvSellingHistory.CurrentRow.Cells[0].Value.ToString();
            bill.DateCreate = (DateTime)dgvSellingHistory.CurrentRow.Cells[1].Value;
            bill.Value = float.Parse(dgvSellingHistory.CurrentRow.Cells[2].Value.ToString());
            bill.StaffID = dgvSellingHistory.CurrentRow.Cells[4].Value.ToString();

            bill.CustomerName = dgvSellingHistory.CurrentRow.Cells[3].Value.ToString();

            new FormBill(bill).Show();
        }

        private void dgvImportHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Imported bill = new Imported();
            bill.ID = dgvImportHistory.CurrentRow.Cells[0].Value.ToString();
            bill.DateCreate = (DateTime)dgvImportHistory.CurrentRow.Cells[1].Value;
            bill.Value = float.Parse(dgvImportHistory.CurrentRow.Cells[2].Value.ToString());
            bill.StaffID = dgvImportHistory.CurrentRow.Cells[3].Value.ToString();

            new FormBill(bill).Show();
        }

        private void btnMakeChartProduct_Click(object sender, EventArgs e)
        {
            if (cbTypeChartProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại biểu đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa biểu đồ cũ
            cbInformationPlus.Series.Clear();
            cbInformationPlus.ChartAreas.Clear();
            cbInformationPlus.Legends.Clear();
            cbInformationPlus.Titles.Clear();

            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("ChartArea1");
            cbInformationPlus.ChartAreas.Add(chartArea);

            var legend = new System.Windows.Forms.DataVisualization.Charting.Legend("Legend1");
            cbInformationPlus.Legends.Add(legend);

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Series1")
            {
                ChartArea = "ChartArea1",
                Legend = "Legend1"
            };

            // Xác định khoảng thời gian
            DateTime toDate = DateTime.Today;
            DateTime fromDate;

            if (rad7daysProduct.Checked)
                fromDate = toDate.AddDays(-6);
            else if (rad30daysProduct.Checked)
                fromDate = toDate.AddDays(-29);
            else // 12 tháng
                fromDate = toDate.AddYears(-1).AddDays(1);

            string timeRange = $"{fromDate:dd/MM/yyyy} - {toDate:dd/MM/yyyy}";

            Dictionary<string, double> data = null;
            string title = "";

            int index = cbTypeChartProduct.SelectedIndex;

            switch (index)
            {
                case 0: // Nhập theo tên
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    data = bus_productStat.GetImportPercentByProductName(fromDate, toDate);
                    title = $"Tỷ lệ nhập hàng theo tên sản phẩm\n({timeRange})";
                    break;

                case 1: // Nhập theo loại
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    data = bus_productStat.GetImportPercentByCategory(fromDate, toDate);
                    title = $"Tỷ lệ nhập hàng theo loại sản phẩm\n({timeRange})";
                    break;

                case 2: // Bán theo tên
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    data = bus_productStat.GetSalePercentByProductName(fromDate, toDate);
                    title = $"Tỷ lệ bán hàng theo tên sản phẩm\n({timeRange})";
                    break;

                case 3: // Bán theo loại
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    data = bus_productStat.GetSalePercentByCategory(fromDate, toDate);
                    title = $"Tỷ lệ bán hàng theo loại sản phẩm\n({timeRange})";
                    break;

                case 4: // Doanh số tùy chọn
                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string productName = comboBox1.SelectedItem.ToString();
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    data = bus_productStat.GetRevenueByProduct(fromDate, toDate, productName);
                    title = $"Doanh số sản phẩm: {productName}\n({timeRange})";
                    break;
            }

            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbInformationPlus.Titles.Add("Không có dữ liệu");
                return;
            }

            // Thêm dữ liệu vào series
            foreach (var item in data)
            {
                var point = series.Points.Add(item.Value);
                point.AxisLabel = item.Key;
                point.Label = index == 4 ? $"{item.Value:#,##0} VNĐ" : $"{item.Value}%";
                point.LegendText = item.Key;
            }

            cbInformationPlus.Series.Add(series);
            cbInformationPlus.Titles.Add(title);

            // Tùy chỉnh đẹp hơn
            cbInformationPlus.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            if (series.ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie)
            {
                series["PieLabelStyle"] = "Outside";
                series["PieLineColor"] = "Black";
            }
        }
    }
}
