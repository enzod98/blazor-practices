using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse : ICRUData<WarehouseEntity>
    {
        public void CreateItem(WarehouseEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oEntity);
                db.SaveChanges();
            }
        }

        public List<WarehouseEntity> EntityList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public void UpdateItem(WarehouseEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
