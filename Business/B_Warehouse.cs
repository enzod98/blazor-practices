using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {
        public static void CreateItem(WarehouseEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oEntity);
                db.SaveChanges();
            }
        }

        public static List<WarehouseEntity> EntityList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static void UpdateItem(WarehouseEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
