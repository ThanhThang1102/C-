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
    public partial class FormStaff : Form
    {
        private BUS_Contract bus_contract;
        private BUS_Staff bus_staff;

        private Staff staff = null;

        public FormStaff(Staff staff)
        {
            InitializeComponent();

            bus_contract = new BUS_Contract();
            bus_staff = new BUS_Staff();

            LoadContentCombobox();
            this.staff = staff;

            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = staff.Name;
            txtID.Text = staff.ID;
            dtPickDoB.Value = staff.DateOfBirth;
            txtAddress.Text = staff.Address;
            cbGender.SelectedIndex = cbGender.FindString(staff.Gender.Trim());
            txtCitizenID.Text = staff.CitizenID;
            txtEmail.Text = staff.Email;
            txtPhone.Text = staff.Phone;

            picRepresent.Image = staff.Images;

            if (staff.Name != "") // Not a new staff
            {
                Contract contracts = bus_contract.GetNewestContractOfStaff(staff.ID);
                txtContractID.Text = contracts.ID;
                dtPickStart.Value = contracts.DayStart;
                dtPickEnd.Value = contracts.DayEnd;
                cbTypeWork.SelectedIndex = cbTypeWork.FindString(contracts.E_typeWork.ToString());

                if (cbTypeWork.Text == "parttime")
                    cbSpells.SelectedIndex = cbSpells.FindString(contracts.E_spells.ToString());
                else
                    cbSpells.Enabled = false;
            }
        }

        private bool isValid(Staff staff)
        {
            if (staff.Name == "" || staff.Address == "" || staff.CitizenID.Length < 9 || staff.Phone.Length < 10)
                return false;
            if (!Checking.IsValidEmail(staff.Email)) // Check email valid
                return false;
            if (staff.DateOfBirth >= DateTime.Now || staff.getAge() < 16)
                return false;
            if (staff.Images == null)
                return false;
            return true;
        }

        private void LoadContentCombobox()
        {
            cbGender.DataSource = System.Enum.GetValues(typeof(GenderVietnamese));
            cbTypeWork.DataSource = System.Enum.GetValues(typeof(TypeWork));
            cbSpells.DataSource = System.Enum.GetValues(typeof(Spells));
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Chọn ảnh sản phẩm";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    picRepresent.Image = Image.FromStream(fs);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            staff.Name = txtName.Text;
            staff.Gender = cbGender.Text;
            staff.DateOfBirth = dtPickDoB.Value;
            staff.Address = txtAddress.Text;
            staff.CitizenID = txtCitizenID.Text;
            staff.Email = txtEmail.Text;
            staff.Phone = txtPhone.Text;

            staff.Images = picRepresent.Image;

            if (isValid(staff))
            {
                if (bus_staff.GetStaff(staff.ID) == null) // new Staff
                {
                    if (bus_staff.Create(staff))
                    {
                        MessageBox.Show("Bổ sung nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm thông tin!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (bus_staff.Update(staff))
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thể điều chỉnh thông tin!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin chưa hợp lệ!\nVui lòng điều chỉnh lại!", "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTypeWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSpells.Enabled = cbTypeWork.Text.Equals("parttime");
        }
    }
}
