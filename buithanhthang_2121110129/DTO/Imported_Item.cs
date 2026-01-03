using System;
using System.Collections.Generic;
using System.Text;

namespace buithanhthang_2121110129.DTO
{
    public class Imported_Item : Bill_Item
    {
        public Imported_Item(int iD, string billID, string productID, float price, int quantity) :
            base(iD, billID, productID, price, quantity)
        {
        }
    }
}
