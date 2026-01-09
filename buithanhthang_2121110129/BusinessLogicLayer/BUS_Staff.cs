using buithanhthang_2121110129.DataAccessLayer;
using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace buithanhthang_2121110129.BusinessLogicLayer
{
    internal class BUS_Staff : IControl<Staff>, IStaffServices
    {
        private DAO_Staff dao;

        public BUS_Staff()
        {
            dao = new DAO_Staff();
        }

        public bool Create(Staff staff)
        {
            return dao.Create(staff);
        }

        public bool Update(Staff staff)
        {
            return dao.Update(staff);
        }

        public bool Delete(Staff staff)
        {
            return dao.Delete(staff);
        }

        public Staff GetStaff(string id)
        {
            try
            {
                return dao.GetStaff(id);
            }
            catch (Exception)
            {
                throw new Exception("Can not find this staff!");
            }
        }

        public DataTable GetAllStaff()
        {
            return dao.GetAllStaff();
        }

        public int GetNumberOfStaff()
        {
            return dao.GetNumberOfStaff();
        }

        public DataTable FindStaffByAddress(string address)
        {
            return dao.FindStaffByAddress(address);
        }

        public DataTable FindStaffByName(string name)
        {
            return dao.FindStaffByName(name);
        }

        public DataTable FindStaffByAgeRange(float from, float to)
        {
            return dao.FindStaffByAgeRange(from, to);
        }

        public DataTable FindStaffByContractStatus(string status)
        {
            return dao.FindStaffByContractStatus(status);
        }

        public DataTable FindStaffByGender(string gender)
        {
            return dao.FindStaffByGender(gender);
        }

        public DataTable FindStaffBySpells(string spells)
        {
            return dao.FindStaffBySpells(spells);
        }

        public DataTable FindStaffByTypeWork(string typeWork)
        {
            return dao.FindStaffByTypeWork(typeWork);
        }
        public string GetNextStaffID()
        {
            string query = @"
                SELECT MAX(CAST(ID AS INT))
                FROM Staff
                WHERE ISNUMERIC(ID) = 1 AND LEN(ID) <= 10"; // LEN <=10 để tránh ID dài kiểu timestamp

            object result = DataProvider.Instance.ExecuteScalar(query, CommandType.Text, null);

            int nextID = 1; // Nếu bảng rỗng hoặc không có ID số nào

            if (result != null && result != DBNull.Value)
            {
                nextID = Convert.ToInt32(result) + 1;
            }

            return nextID.ToString();
        }
    }
}
