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

        private Contract currentContract; // hợp đồng đang xử lý (mới hoặc cũ)
        private bool isEditMode = false;  // đang sửa hay tạo mới
        public FormContract(Staff staff) : this(staff, null) { }
        // Constructor mới: cho sửa hợp đồng
        public FormContract(Staff staff, Contract contractToEdit)
        {
            InitializeComponent();

            bus_contract = new BUS_Contract();
            bus_staff = new BUS_Staff();
            LoadContentCombobox();

            this.staff = staff;

            if (contractToEdit == null)
            {
                // === TẠO MỚI ===
                isEditMode = false;
                currentContract = new Contract();
                currentContract.StaffID = staff.ID;
                currentContract.ID = GetFormatString.MakingIDNow();

                txtContractID.Text = currentContract.ID;
                dtPickStart.Value = DateTime.Today;
                dtPickEnd.Value = DateTime.Today.AddYears(1);
                cbTypeWork.SelectedIndex = 0;
                txtSalary.Text = "0";
                this.Text = "Tạo hợp đồng mới";
            }
            else
            {
                // === SỬA HỢP ĐỒNG ===
                isEditMode = true;
                currentContract = contractToEdit;

                txtContractID.Text = currentContract.ID;
                txtContractID.ReadOnly = true; // không cho sửa mã

                dtPickStart.Value = currentContract.DayStart;
                dtPickEnd.Value = currentContract.DayEnd;

                // Chọn loại công việc
                if (currentContract.E_typeWork == "fulltime")
                    cbTypeWork.SelectedIndex = 0;
                else if (currentContract.E_typeWork == "parttime")
                    cbTypeWork.SelectedIndex = 1;

                // Chọn buổi làm việc nếu là parttime
                if (currentContract.E_typeWork == "parttime" && currentContract.E_spells != null)
                {
                    cbSpells.SelectedIndex = cbSpells.FindStringExact(
                        currentContract.E_spells == "morning" ? "Ca sáng" :
                        currentContract.E_spells == "afternoon" ? "Ca chiều" : "Ca tối"
                    );
                }

                txtSalary.Text = currentContract.SolidSalary.ToString("F0"); // không chữ số lẻ

                this.Text = "Sửa hợp đồng";
            }
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
            // Validate chung
            if (dtPickStart.Value > dtPickEnd.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbTypeWork.Text == "parttime" && cbSpells.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn buổi làm việc cho nhân viên part-time!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtSalary.Text.Trim(), out float salary) || salary < 0)
            {
                MessageBox.Show("Mức lương không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật dữ liệu vào currentContract
            currentContract.DayStart = dtPickStart.Value;
            currentContract.DayEnd = dtPickEnd.Value;
            currentContract.E_typeWork = cbTypeWork.Text;
            currentContract.E_spells = cbTypeWork.Text == "parttime" ? cbSpells.Text : null;
            currentContract.SolidSalary = salary;

            bool success;
            string message;

            if (isEditMode)
            {
                success = bus_contract.Update(currentContract);
                message = success ? "Cập nhật hợp đồng thành công!" : "Cập nhật hợp đồng thất bại!";
            }
            else
            {
                success = bus_contract.Create(currentContract);
                message = success ? "Tạo hợp đồng thành công!" : "Tạo hợp đồng thất bại!";
            }

            MessageBox.Show(message, success ? "Thành công" : "Lỗi",
                MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
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
