using buithanhthang_2121110129.BusinessLogicLayer;
using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace buithanhthang_2121110129.UserControl
{
    public partial class UCStaff : System.Windows.Forms.UserControl
    {
        private BUS_Staff bus_staff;
        private BUS_Account bus_account;
        private BUS_Contract bus_contract;

        private bool flagSpells;
        private Staff _staff;

        static UCStaff _obj;
        public static UCStaff Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCStaff();
                }
                return _obj;
            }
        }

        public UCStaff()
        {
            InitializeComponent();
            _staff = new Staff();

            bus_staff = new BUS_Staff();
            bus_account = new BUS_Account();
            bus_contract = new BUS_Contract();
            LoadContentCombobox();

            LoadData();
        }

        private void LoadData()
        {
            ClearInformation();
            dgvStaff.Controls.Clear();

            dgvStaff.DataSource = bus_staff.GetAllStaff();

            dgvStaff.Columns[0].Visible = false; //Hide ID column
        }

        private void ClearInformation()
        {
            picRepresent.Image = null;
            txtName.Clear();
            txtGender.Clear();
            txtCitizenID.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            ClearStaffSecretInformation();
        }

        private void ClearStaffSecretInformation()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            dgvContracts.Controls.Clear();
            dgvContracts.DataSource = null;

            btnEditContract.Visible = false;
            btnDeleteContract.Visible = false;
        }


        private void LoadContentCombobox()
        {
            // 1. Dạng công việc: parttime / fulltime → tiếng Việt
            var typeWorkDict = new Dictionary<TypeWork, string>
    {
        { TypeWork.fulltime, "Toàn thời gian" },
        { TypeWork.parttime, "Bán thời gian" }
    };
            cbTypeWork.DataSource = new BindingSource(typeWorkDict, null);
            cbTypeWork.DisplayMember = "Value";
            cbTypeWork.ValueMember = "Key";

            // 2. Buổi làm việc (chỉ dùng cho parttime)
            var spellsDict = new Dictionary<Spells, string>
    {
        { Spells.morning, "Ca sáng" },
        { Spells.afternoon, "Ca chiều" },
        { Spells.night, "Ca tối" }
    };
            cbSpells.DataSource = new BindingSource(spellsDict, null);
            cbSpells.DisplayMember = "Value";
            cbSpells.ValueMember = "Key";

            // 3. Trạng thái hợp đồng
            var contractStatusDict = new Dictionary<StatusOfContract, string>
    {
        { StatusOfContract.Unexpired, "Còn hạn" },
        { StatusOfContract.Expiration_Soon, "Sắp hết hạn" },
        { StatusOfContract.Expired, "Đã hết hạn" }
    };
            cbDateContract.DataSource = new BindingSource(contractStatusDict, null);
            cbDateContract.DisplayMember = "Value";
            cbDateContract.ValueMember = "Key";

            // 4. Giới tính (riêng vì không dùng enum Gender mà dùng GenderVietnamese)
            cbGenderFilter.Items.Clear();
            cbGenderFilter.Items.AddRange(new string[] { "nam", "nữ", "khác" });
            cbGenderFilter.SelectedIndex = 0; // mặc định
        }

        private DataTable getTableFilter(DataTable table, DataTable table_filter)
        {
            DataTable dataTable;
            if (table == null)
            {
                table = table_filter;
                table.PrimaryKey = new DataColumn[] { table.Columns["ID"] };
                dataTable = table;
            }
            else
            {
                dataTable = table.Clone();
                foreach (DataRow row in table_filter.Rows)
                {
                    if (table.Rows.Contains(row[0]))
                    {
                        dataTable.ImportRow(row);
                    }
                }
            }
            return dataTable;
        }

        #region Filter_Change
        private void chbTypeWork_CheckedChanged(object sender, EventArgs e)
        {
            cbTypeWork.Enabled = !cbTypeWork.Enabled;
        }

        private void chbSpells_CheckedChanged(object sender, EventArgs e)
        {
            cbSpells.Enabled = !cbSpells.Enabled;
        }

        private void chbDateContract_CheckedChanged(object sender, EventArgs e)
        {
            cbDateContract.Enabled = !cbDateContract.Enabled;
        }

        private void chbGender_CheckedChanged(object sender, EventArgs e)
        {
            cbGenderFilter.Enabled = !cbGenderFilter.Enabled;
        }

        private void chbAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtAddressFilter.Enabled = !txtAddressFilter.Enabled;
        }

        private void chbAge_CheckedChanged(object sender, EventArgs e)
        {
            numUDFrom.Enabled = !numUDFrom.Enabled;
            numUDTo.Enabled = !numUDTo.Enabled;
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            txtNameFilter.Enabled = !txtNameFilter.Enabled;
        }

        private void cbTypeWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagSpells = true;
            if (cbTypeWork.SelectedItem.ToString() == TypeWork.fulltime.ToString())
            {
                flagSpells = false;
            }
            chbSpells.Checked = flagSpells;
            chbSpells.Enabled = flagSpells;
        }
        #endregion

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FormStaff(new Staff()).ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameFilter.Clear();
            txtAddressFilter.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!chbName.Checked && !chbAge.Checked && !chbAddress.Checked && !chbGender.Checked &&
                !chbDateContract.Checked && !chbTypeWork.Checked && !chbSpells.Checked)
                return;

            DataTable table = null;
            DataTable table_filter;

            if (chbName.Checked)
            {
                table_filter = bus_staff.FindStaffByName(txtNameFilter.Text);
                table = getTableFilter(table, table_filter);
            }
            if (chbAge.Checked)
            {
                int from = (int)numUDFrom.Value;
                int to = (int)numUDTo.Value;
                if (from > to)
                {
                    MessageBox.Show("Giá trị bắt đầu phải lớn hơn hoặc bằng giá trị kết thúc!", "THÔNG BÁO");
                    return;
                }

                table_filter = bus_staff.FindStaffByAgeRange(from, to);
                table = getTableFilter(table, table_filter);
            }
            if (chbAddress.Checked)
            {
                table_filter = bus_staff.FindStaffByAddress(txtAddressFilter.Text);
                table = getTableFilter(table, table_filter);
            }
            if (chbGender.Checked)
            {
                table_filter = bus_staff.FindStaffByGender(cbGenderFilter.Text);
                table = getTableFilter(table, table_filter);
            }
            if (chbDateContract.Checked)
            {
                StatusOfContract selectedStatus = (StatusOfContract)cbDateContract.SelectedValue;
                table_filter = bus_staff.FindStaffByContractStatus(selectedStatus.ToString());
                table = getTableFilter(table, table_filter);
            }
            if (chbTypeWork.Checked)
            {
                TypeWork selectedType = (TypeWork)cbTypeWork.SelectedValue;
                table_filter = bus_staff.FindStaffByTypeWork(selectedType.ToString());
                table = getTableFilter(table, table_filter);
            }
            if (chbSpells.Checked)
            {
                Spells selectedSpell = (Spells)cbSpells.SelectedValue;
                table_filter = bus_staff.FindStaffBySpells(selectedSpell.ToString());
                table = getTableFilter(table, table_filter);
            }

            dgvStaff.Controls.Clear();
            dgvStaff.DataSource = table;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            btnShowPassword.Text = (btnShowPassword.Text == "Hiện mật khẩu") ? "Ẩn mật khẩu" : "Hiện mật khẩu";
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '*') ? '\0' : '*';
        }
        private bool isChangingPassword = false;
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!isChangingPassword)
            {
                isChangingPassword = true;
                txtPassword.ReadOnly = false;
                txtPassword.PasswordChar = '*';
                txtPassword.Clear();
                txtPassword.Focus();

                btnChangePassword.Text = "Lưu";
                btnShowPassword.Visible = true;
                MessageBox.Show("Nhập mật khẩu mới và bấm 'Lưu' để xác nhận.",
                    "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string newPassword = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPassword.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Account currentAccount = bus_account.GetAccountByStaffID(_staff.ID);
                currentAccount.Password = newPassword;

                if (bus_account.Update(currentAccount))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isChangingPassword = false;
                    txtPassword.ReadOnly = true;
                    txtPassword.Text = newPassword;
                    btnChangePassword.Text = "Đổi mật khẩu";
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditStaffInfor_Click(object sender, EventArgs e)
        {
            if (_staff.Name != "")
                new FormStaff(_staff).ShowDialog();
        }

        private void btnMakeContract_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn nhân viên chưa
            if (_staff == null || string.IsNullOrEmpty(_staff.ID) || string.IsNullOrEmpty(_staff.Name))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên từ danh sách trước khi tạo hợp đồng!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form tạo hợp đồng mới, truyền vào nhân viên hiện tại
            FormContract formContract = new FormContract(_staff);
            if (formContract.ShowDialog() == DialogResult.OK)
            {
                // Sau khi tạo hợp đồng thành công, reload lại danh sách hợp đồng của nhân viên (nếu đang hiển thị)
                if (!string.IsNullOrEmpty(txtUsername.Text)) // đang xem chi tiết nhân viên
                {
                    dgvContracts.DataSource = bus_contract.GetAllContractOfStaff(_staff.ID);
                }

                MessageBox.Show("Tạo hợp đồng mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xóa thông tin nhân viên {_staff.Name}?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bus_staff.Delete(_staff))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {_staff.Name} thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    _staff = new Staff();
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {_staff.Name} không thành công!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvStaff.CurrentRow == null) return;
            ClearStaffSecretInformation();
            var id = dgvStaff.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;
            _staff = bus_staff.GetStaff(dgvStaff.CurrentRow.Cells[0].Value.ToString()); // Id cell

            txtName.Text = _staff.Name;
            txtGender.Text = _staff.Gender;
            dtPickDoB.Value = _staff.DateOfBirth;
            txtCitizenID.Text = _staff.CitizenID;
            txtAddress.Text = _staff.Address;
            txtEmail.Text = _staff.Email;
            txtPhone.Text = _staff.Phone;

            picRepresent.Image = _staff.Images;
        }

        private void btnLoadStaffInfor_Click(object sender, EventArgs e)
        {
            Account acc = bus_account.GetAccountByStaffID(_staff.ID);
            txtUsername.Text = acc.Username;
            txtPassword.Text = acc.Password;

            dgvContracts.DataSource = bus_contract.GetAllContractOfStaff(_staff.ID);

            btnEditContract.Visible = true;
            btnDeleteContract.Visible = true;

            isChangingPassword = false;
            txtPassword.ReadOnly = true;
            btnChangePassword.Text = "Đổi mật khẩu";
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            if (dgvContracts.CurrentRow == null || dgvContracts.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng từ danh sách để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contractID = dgvContracts.CurrentRow.Cells[0].Value?.ToString();

            if (string.IsNullOrEmpty(contractID))
            {
                MessageBox.Show("Không lấy được mã hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa hợp đồng:\nMã: {contractID}\nNhân viên: {_staff.Name}?\n\nHành động này không thể hoàn tác!",
                "Xác nhận xóa hợp đồng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            Contract contractToDelete = new Contract();
            contractToDelete.ID = contractID;

            if (bus_contract.Delete(contractToDelete))
            {
                MessageBox.Show("Xóa hợp đồng thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvContracts.DataSource = bus_contract.GetAllContractOfStaff(_staff.ID);
            }
            else
            {
                MessageBox.Show("Không thể xóa hợp đồng. Có thể đã bị xóa trước đó hoặc xảy ra lỗi.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            if (dgvContracts.CurrentRow == null || dgvContracts.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng từ danh sách để sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contractID = dgvContracts.CurrentRow.Cells[0].Value.ToString();

            Contract contractToEdit = null;
            DataTable dt = bus_contract.GetAllContractOfStaff(_staff.ID);
            foreach (DataRow row in dt.Rows)
            {
                if (row["ID"].ToString() == contractID)
                {
                    contractToEdit = new Contract(
                        iD: row["ID"].ToString(),
                        staffID: row["StaffID"].ToString(),
                        dayStart: (DateTime)row["DayStart"],
                        dayEnd: (DateTime)row["DayEnd"],
                        e_typeWork: row["TypeWork"].ToString(),
                        e_spells: row["Spells"] == DBNull.Value ? null : row["Spells"].ToString(),
                        solidSalary: Convert.ToSingle(row["SolidSalary"])
                    );
                    break;
                }
            }

            if (contractToEdit == null)
            {
                MessageBox.Show("Không tìm thấy thông tin hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormContract formEdit = new FormContract(_staff, contractToEdit);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                dgvContracts.DataSource = bus_contract.GetAllContractOfStaff(_staff.ID);
                MessageBox.Show("Cập nhật hợp đồng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
