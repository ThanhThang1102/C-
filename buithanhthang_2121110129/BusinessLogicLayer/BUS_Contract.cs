using buithanhthang_2121110129.DataAccessLayer;
using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace buithanhthang_2121110129.BusinessLogicLayer
{
    internal class BUS_Contract : IControl<Contract>, IContractServices
    {
        private DAO_Contract dao;

        public BUS_Contract()
        {
            dao = new DAO_Contract();
        }

        public bool Create(Contract contract)
        {
            return dao.Create(contract);
        }

        public bool Update(Contract contract)
        {
            return dao.Update(contract);
        }

        public bool Delete(Contract contract)
        {
            try
            {
                if (string.IsNullOrEmpty(contract.ID))
                    return false;

                string query = "DELETE FROM contracts WHERE ID = @ID";
                int rows = DataProvider.Instance.ExecuteNonQuery(query, CommandType.Text,
                    new SqlParameter("@ID", contract.ID.Trim()));

                if (rows > 0)
                    return true;
                else
                {
                    MessageBox.Show("Không tìm thấy hợp đồng để xóa (có thể đã bị xóa trước đó)!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
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
            return dao.GetAllContractOfStaff(staff_id);
        }

        public Contract GetNewestContractOfStaff(string staff_id)
        {
            return dao.GetNewestContractOfStaff(staff_id);
        }
    }

}
