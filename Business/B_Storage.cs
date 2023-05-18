using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage : ICRUData<StorageEntity>
    {
        public void CreateItem(StorageEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oEntity);
                db.SaveChanges();
            }
        }

        public List<StorageEntity> EntityList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public void UpdateItem(StorageEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
