﻿using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;
using Business.Interfaces;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> EntityList()
        {
            using(var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static CategoryEntity GetCategoryByID(string ID)
        {
            using (var db = new InventaryContext())
            {
                return db.Categories.Where(x => x.CategoryId == ID).FirstOrDefault();
            }
        }

        public static void CreateItem(CategoryEntity oEntity)
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Add(oEntity);
                db.SaveChanges();
            }
        }

        public static void UpdateItem(CategoryEntity oEntity) 
        {
            using(var db = new InventaryContext())
            {
                db.Categories.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
