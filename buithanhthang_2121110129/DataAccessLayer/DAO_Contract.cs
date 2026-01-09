using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace buithanhthang_2121110129.DataAccessLayer
{
    internal class DAO_Contract : IControl<Contract>, IContractServices
    {
        public bool Create(Contract contract)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", contract.ID ?? (object)DBNull.Value),
                    new SqlParameter("@StaffID", contract.StaffID ?? (object)DBNull.Value),
                    new SqlParameter("@DayStart", contract.DayStart),
                    new SqlParameter("@DayEnd", contract.DayEnd),
                    new SqlParameter("@TypeWork", contract.E_typeWork ?? (object)DBNull.Value),
                    new SqlParameter("@Spells", contract.E_spells ?? (object)DBNull.Value), // ← Quan trọng: xử lý NULL đúng cách
                    new SqlParameter("@SolidSalary", contract.SolidSalary)
                };

                // Chỉ truyền tên SP, KHÔNG cần "exec"
                int rows = DataProvider.Instance.ExecuteNonQuery(
                    "sp_Insertcontracts", // ← Kiểm tra xem tên SP trong DB có đúng là cái này không
                    CommandType.StoredProcedure,
                    parameters);

                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo hợp đồng:\n" + ex.Message,
                    "LỖI DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(Contract contract)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@ID", contract.ID),
                    new SqlParameter("@StaffID", contract.StaffID),
                    new SqlParameter("@DayStart", contract.DayStart),
                    new SqlParameter("@DayEnd", contract.DayEnd),
                    new SqlParameter("@TypeWork", contract.E_typeWork),
                    new SqlParameter("@Spells", contract.E_spells ?? (object)DBNull.Value),
                    new SqlParameter("@SolidSalary", contract.SolidSalary)
                };

                int rows = DataProvider.Instance.ExecuteNonQuery(
                    "sp_Updatecontracts",
                    CommandType.StoredProcedure,
                    parameters);

                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật hợp đồng:\n" + ex.Message,
                    "LỖI DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(Contract contract)
        {
            try
            {
                int rows = DataProvider.Instance.ExecuteNonQuery(
                    "sp_Deletecontracts",
                    CommandType.StoredProcedure,
                    new SqlParameter("@ID", contract.ID));

                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hợp đồng:\n" + ex.Message,
                    "LỖI DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable GetAllContractOfStaff(string staff_id)
        {
            string query = "SELECT * FROM contracts WHERE StaffID = @staffID";
            var param = new SqlParameter("@staffID", staff_id);
            return DataProvider.Instance.ExecuteQuery(query, CommandType.Text, param);
        }

        public Contract GetNewestContractOfStaff(string staff_id)
        {
            string query = @"
                SELECT TOP 1 * 
                FROM contracts 
                WHERE StaffID = @staffID 
                ORDER BY DayStart DESC";

            var param = new SqlParameter("@staffID", staff_id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, CommandType.Text, param);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Contract(
                iD: row["ID"].ToString(),
                staffID: row["StaffID"].ToString(),
                dayStart: (DateTime)row["DayStart"],
                dayEnd: (DateTime)row["DayEnd"],
                e_typeWork: row["TypeWork"].ToString(),
                e_spells: row["Spells"] == DBNull.Value ? null : row["Spells"].ToString(),
                solidSalary: Convert.ToSingle(row["SolidSalary"])
            );
        }
    }
}