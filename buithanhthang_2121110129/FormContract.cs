using buithanhthang_2121110129.BusinessLogicLayer;
using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Enum;
using buithanhthang_2121110129.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129
{
    public partial class FormContract : Form
    {
        private BUS_Contract bus_contract;
        private BUS_Staff bus_staff;
        private Staff staff = null;
        private Contract newContract;

        public FormContract(Staff staff)
        {
            InitializeComponent();
            bus_contract = new BUS_Contract();
            bus_staff = new BUS_Staff();
            LoadContentCombobox();
            this.staff = staff;

            // Tạo hợp đồng mới
            newContract = new Contract();
            newContract.StaffID = staff.ID;
            newContract.ID = GetFormatString.MakingIDNow(); // giữ nguyên như yêu cầu

            // Hiển thị thông tin mặc định
            txtContractID.Text = newContract.ID;
            dtPickStart.Value = DateTime.Today;
            dtPickEnd.Value = DateTime.Today.AddYears(1); // mặc định 1 năm
            cbTypeWork.SelectedIndex = 0; // fulltime mặc định
            txtSalary.Text = "0";
        }

        private void LoadContentCombobox()
        {
            cbTypeWork.DataSource = System.Enum.GetValues(typeof(TypeWork));
            cbSpells.DataSource = System.Enum.GetValues(typeof(Spells));
            cbSpells.Enabled = false; // mặc định ẩn vì fulltime
        }

        private void cbTypeWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSpells.Enabled = cbTypeWork.Text.Equals("parttime", StringComparison.OrdinalIgnoreCase);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            if (dtPickStart.Value > dtPickEnd.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbTypeWork.Text.Equals("parttime") && cbSpells.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn buổi làm việc cho nhân viên part-time!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float salary = 0;
            if (!float.TryParse(txtSalary.Text.Trim(), out salary) || salary < 0)
            {
                MessageBox.Show("Mức lương không hợp lệ! Vui lòng nhập số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gán dữ liệu vào contract
            newContract.DayStart = dtPickStart.Value;
            newContract.DayEnd = dtPickEnd.Value;
            newContract.E_typeWork = cbTypeWork.Text;
            newContract.E_spells = cbTypeWork.Text.Equals("parttime") ? cbSpells.Text : null;
            newContract.SolidSalary = salary;

            // Lưu vào database
            if (bus_contract.Create(newContract))
            {
                MessageBox.Show($"Tạo hợp đồng thành công!\nMã hợp đồng: {newContract.ID}\nNhân viên: {staff.Name}",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo hợp đồng thất bại! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region MoveForm (giữ nguyên như cũ)
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
