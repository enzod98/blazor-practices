using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages{ get; set; }
        public DbSet<InputOutputEntity> InOuts{ get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=.\\SQLEXPRESS; Database=InventoryDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity
                {
                    CategoryId = "ASH",
                    CategoryName = "Aseo del hogar"
                },
                new CategoryEntity
                {
                    CategoryId = "PRF",
                    CategoryName = "Perfumería"
                },
                new CategoryEntity
                {
                    CategoryId = "VDJ",
                    CategoryName = "Videojuegos"
                }
            );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega central",
                    WarehouseAddress = "Artigas 1945"
                },
                 new WarehouseEntity
                 {
                     WarehouseId = Guid.NewGuid().ToString(),
                     WarehouseName = "Bodega norte",
                     WarehouseAddress = "Abasto norte"
                 },
                  new WarehouseEntity
                  {
                      WarehouseId = Guid.NewGuid().ToString(),
                      WarehouseName = "Bodega del Este",
                      WarehouseAddress = "Ciudad del este"
                  }
            );
        }
    }
}
