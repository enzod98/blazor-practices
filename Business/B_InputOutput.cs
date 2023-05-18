using Business.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput : ICRUData<InputOutputEntity>
    {
        public void CreateItem(InputOutputEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oEntity);
                db.SaveChanges();
            }
        }

        public List<InputOutputEntity> EntityList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void UpdateItem(InputOutputEntity oEntity)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oEntity);
                db.SaveChanges();
            }
        }
    }
}
