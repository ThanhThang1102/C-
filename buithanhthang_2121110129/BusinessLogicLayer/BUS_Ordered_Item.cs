using buithanhthang_2121110129.DataAccessLayer;
using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace buithanhthang_2121110129.BusinessLogicLayer
{
    internal class BUS_Ordered_Item : IControl<Ordered_Item>
    {
        private DAO_Bill_Item dao;

        public BUS_Ordered_Item()
        {
            dao = new DAO_Bill_Item("Ordered");
        }

        public bool Create(Ordered_Item item)
        {
            return dao.Create(item);
        }

        public bool Update(Ordered_Item item)
        {
            return dao.Update(item);
        }

        public bool Delete(Ordered_Item item)
        {
            return dao.Delete(item);
        }
    }

}
