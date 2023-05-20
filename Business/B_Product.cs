using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product
    {
        public static void CreateItem(ProductEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oEntity);
                db.SaveChanges();
            }
        }

        public static List<ProductEntity> EntityList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity GetProductByID(string ID)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.Where(x => x.ProductId == ID).FirstOrDefault();
            }
        }

        public static void UpdateItem(ProductEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
