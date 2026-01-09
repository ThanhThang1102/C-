using buithanhthang_2121110129.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace buithanhthang_2121110129.BusinessLogicLayer
{
    internal class BUS_ProductStatistic
    {
        private DAO_Bill_Item daoImportedItem;
        private DAO_Bill_Item daoOrderedItem;
        private DAO_Product daoProduct;

        public BUS_ProductStatistic()
        {
            daoImportedItem = new DAO_Bill_Item("Imported");
            daoOrderedItem = new DAO_Bill_Item("Ordered");
            daoProduct = new DAO_Product();
        }

        // 1. Phần trăm sản phẩm nhập vào theo tên
        public Dictionary<string, double> GetImportPercentByProductName(DateTime from, DateTime to)
        {
            return GetPercentFromDetails(
                daoImportedItem.GetAllItemsInPeriod(from, to.AddDays(1)),
                "ProductName"
            );
        }

        // 2. Phần trăm sản phẩm nhập vào theo loại
        public Dictionary<string, double> GetImportPercentByCategory(DateTime from, DateTime to)
        {
            return GetPercentFromDetails(daoImportedItem.GetAllItemsInPeriod(from, to.AddDays(1)), "TypeProduct");
        }

        // 3. Phần trăm sản phẩm bán ra theo tên
        public Dictionary<string, double> GetSalePercentByProductName(DateTime from, DateTime to)
        {
            return GetPercentFromDetails(daoOrderedItem.GetAllItemsInPeriod(from, to.AddDays(1)), "ProductName");
        }

        // 4. Phần trăm sản phẩm bán ra theo loại
        public Dictionary<string, double> GetSalePercentByCategory(DateTime from, DateTime to)
        {
            return GetPercentFromDetails(daoOrderedItem.GetAllItemsInPeriod(from, to.AddDays(1)), "TypeProduct");
        }

        // 5. Doanh số sản phẩm bán ra (theo tên sản phẩm hoặc tất cả)
        public Dictionary<string, double> GetRevenueByProduct(DateTime from, DateTime to, string productName = null)
        {
            DataTable dt = daoOrderedItem.GetAllItemsInPeriod(from, to.AddDays(1));

            Dictionary<string, double> revenueDict = new Dictionary<string, double>();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["ProductName"].ToString();

                // Nếu có lọc theo tên sản phẩm
                if (!string.IsNullOrEmpty(productName) && !name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                    continue;

                double totalPrice = Convert.ToDouble(row["Quantity"]) * Convert.ToDouble(row["Price"]);
                if (revenueDict.ContainsKey(name))
                    revenueDict[name] += totalPrice;
                else
                    revenueDict[name] = totalPrice;
            }

            return revenueDict;
        }

        // Hàm hỗ trợ chung để tính phần trăm dựa trên số lượng
        private Dictionary<string, double> GetPercentFromDetails(DataTable details, string groupByColumn)
        {
            if (details.Rows.Count == 0) return new Dictionary<string, double>();

            Dictionary<string, int> countDict = new Dictionary<string, int>();
            int totalQuantity = 0;

            foreach (DataRow row in details.Rows)
            {
                string key = row[groupByColumn].ToString();
                int qty = Convert.ToInt32(row["Quantity"]);
                totalQuantity += qty;

                if (countDict.ContainsKey(key))
                    countDict[key] += qty;
                else
                    countDict[key] = qty;
            }

            Dictionary<string, double> percentDict = new Dictionary<string, double>();
            foreach (var kvp in countDict)
            {
                double percent = (totalQuantity > 0) ? (kvp.Value * 100.0 / totalQuantity) : 0;
                percentDict[kvp.Key] = Math.Round(percent, 2);
            }

            return percentDict;
        }
    }
}