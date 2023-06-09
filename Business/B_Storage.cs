﻿using Business.Interfaces;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public static void CreateItem(StorageEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oEntity);
                db.SaveChanges();
            }
        }


        public static bool IsProductInWarehouse(string idProduct)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.FirstOrDefault(x => x.StorageId == idProduct);

                return product != null;
            }
        }

        public static List<StorageEntity> EntityList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static List<StorageEntity> EntityListByWarehouse(string warehouseId)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                        .Include(s => s.Product)
                        .Include(s => s.Warehouse)
                        .Where(x => x.WarehouseId == warehouseId)
                        .ToList();
            }
        }

        public static void UpdateItem(StorageEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
