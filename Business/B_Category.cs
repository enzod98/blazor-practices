using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;
using Business.Interfaces;

namespace Business
{
    public class B_Category : ICRUData<CategoryEntity>
    {
        public List<CategoryEntity> EntityList()
        {
            using(var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public void CreateItem(CategoryEntity oEntity)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Add(oEntity);
                db.SaveChanges();
            }
        }

        public void UpdateItem(CategoryEntity oEntity) 
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
