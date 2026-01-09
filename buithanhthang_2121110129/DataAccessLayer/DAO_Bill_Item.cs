using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace buithanhthang_2121110129.DataAccessLayer
{
    internal class DAO_Bill_Item : IControl<Bill_Item>
    {
        private string typeBill;
        protected string detailTableName;
        public DAO_Bill_Item(string typeBill)
        {
            this.typeBill = typeBill;
            this.detailTableName = typeBill + "Detail";
        }

        public bool Create(Bill_Item item)
        {
            return (DataProvider.Instance.ExecuteNonQuery($"sp_Insert{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID),
                new SqlParameter("@ProductID", item.ProductID),
                new SqlParameter("@Price", item.Price),
                new SqlParameter("@Quantity", item.Quantity),
                new SqlParameter("@Total", item.Price * item.Quantity)) > 0) ? true : false;
        }

        public bool Update(Bill_Item item)
        {
            return (DataProvider.Instance.ExecuteNonQuery($"sp_Update{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID),
                new SqlParameter("@ProductID", item.ProductID),
                new SqlParameter("@Price", item.Price),
                new SqlParameter("@Quantity", item.Quantity),
                new SqlParameter("@Total", item.Price * item.Quantity)) > 0) ? true : false;
        }

        public bool Delete(Bill_Item item)
        {
            return (DataProvider.Instance.ExecuteNonQuery($"sp_Delete{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID)) > 0) ? true : false;
        }

        /// <summary>
        /// Lấy tất cả chi tiết hóa đơn (Imported_Item hoặc Ordered_Item) trong khoảng thời gian
        /// Kèm theo tên sản phẩm và loại sản phẩm từ bảng Product
        /// </summary>
        /// <param name="from">Ngày bắt đầu (bao gồm)</param>
        /// <param name="to">Ngày kết thúc (không bao gồm ngày to - nên cộng thêm 1 ngày khi gọi)</param>
        /// <returns>DataTable chứa các cột: BillID, ProductID, ProductName, TypeProduct, Price, Quantity, Total, DateCreate...</returns>
        public DataTable GetAllItemsInPeriod(DateTime from, DateTime to)
        {
            string query = $@"
            SELECT 
                bi.*,
                p.Name AS ProductName,
                p.TypeProduct
            FROM [{detailTableName}] bi
            INNER JOIN [{typeBill}] b ON bi.[{typeBill}ID] = b.ID
            INNER JOIN [Product] p ON bi.ProductID = p.ID
            WHERE b.DateCreate >= @from AND b.DateCreate < @to
            ORDER BY b.DateCreate DESC";

            var parameters = new[]
            {
            new SqlParameter("@from", from),
            new SqlParameter("@to", to)
        };

            return DataProvider.Instance.ExecuteQuery(query, CommandType.Text, parameters);
        } 
    }

}
