using buithanhthang_2121110129.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace buithanhthang_2121110129.Services
{
    public interface IContractServices
    {
        /// <summary>
        /// Get all contracts of staff in DBMS
        /// </summary>
        /// <param name="staff_id"></param>
        /// <returns></returns>
        DataTable GetAllContractOfStaff(string staff_id);

        /// <summary>
        /// Get the newest contract information (to check)
        /// </summary>
        /// <param name="staff_id"></param>
        /// <returns></returns>
        Contract GetNewestContractOfStaff(string staff_id);
    }
}
