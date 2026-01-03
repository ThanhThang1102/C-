using buithanhthang_2121110129.DataAccessLayer;
using buithanhthang_2121110129.DTO;
using buithanhthang_2121110129.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace buithanhthang_2121110129.BusinessLogicLayer
{
    internal class BUS_Imported_Item : IControl<Imported_Item>
    {
        private DAO_Bill_Item dao;

        public BUS_Imported_Item()
        {
            dao = new DAO_Bill_Item("Imported");
        }

        public bool Create(Imported_Item item)
        {
            return dao.Create(item);
        }

        public bool Update(Imported_Item item)
        {
            return dao.Update(item);
        }

        public bool Delete(Imported_Item item)
        {
            return dao.Delete(item);
        }

    }
}
