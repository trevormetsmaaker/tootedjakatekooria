using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tootedjakatekooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Vorst" },
                new Category { CategoryID = 2, CategoryName = "Hakkliha" },
                new Category { CategoryID = 3, CategoryName = "Sai" },
                new Category { CategoryID = 4, CategoryName = "Kurk" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryID = 1, ProductName = "LasteVorst" },
                new Product { ProductId = 2, CategoryID = 1, ProductName = "JuustuVorst" },
                new Product { ProductId = 3, CategoryID = 1, ProductName = "SuitsuVorst" },
                new Product { ProductId = 4, CategoryID = 1, ProductName = "DoktoriVorst" },
                new Product { ProductId = 5, CategoryID = 1, ProductName = "KevadineVorst" },
                new Product { ProductId = 6, CategoryID = 2, ProductName = "SeaHakkliha" },
                new Product { ProductId = 7, CategoryID = 2, ProductName = "KanaHakkliha" },
                new Product { ProductId = 8, CategoryID = 2, ProductName = "VeiseHakkliha" },
                new Product { ProductId = 9, CategoryID = 2, ProductName = "VeiseJaSeaHakkliha" },
                new Product { ProductId = 10, CategoryID = 2, ProductName = "VeganHakkliha" },
                new Product { ProductId = 11, CategoryID = 2, ProductName = "ProteiiniHakkliha" },
                new Product { ProductId = 12, CategoryID = 2, ProductName = "DelikatessHakkliha" },
                new Product { ProductId = 13, CategoryID = 3, ProductName = "KoduneSai" },
                new Product { ProductId = 14, CategoryID = 3, ProductName = "PereNaiseSai" },
                new Product { ProductId = 15, CategoryID = 3, ProductName = "RöstSai" },
                new Product { ProductId = 16, CategoryID = 3, ProductName = "TäisteraSai" },
                new Product { ProductId = 17, CategoryID = 3, ProductName = "PrantsuseSai" },
                new Product { ProductId = 18, CategoryID = 3, ProductName = "KirdeSai" },
                new Product { ProductId = 19, CategoryID = 3, ProductName = "GluteenivabaSai" },
                new Product { ProductId = 20, CategoryID = 3, ProductName = "JuubeliSai" },
                new Product { ProductId = 21, CategoryID = 3, ProductName = "SuurkirdeSai" },
                new Product { ProductId = 22, CategoryID = 4, ProductName = "VärskeKurk" },
                new Product { ProductId = 23, CategoryID = 4, ProductName = "HapuKurk" },
                new Product { ProductId = 24, CategoryID = 4, ProductName = "SoolaKurk" },
                new Product { ProductId = 25, CategoryID = 4, ProductName = "PeipsiKurk" },
                new Product { ProductId = 26, CategoryID = 4, ProductName = "vürtsiKurk" },
                new Product { ProductId = 27, CategoryID = 4, ProductName = "MiniKurk" },
                new Product { ProductId = 28, CategoryID = 4, ProductName = "DelikatessKurk" },
                new Product { ProductId = 29, CategoryID = 4, ProductName = "DelikatessHapuKurk" },
                new Product { ProductId = 31, CategoryID = 4, ProductName = "VõileivaKurk" },
                new Product { ProductId = 32, CategoryID = 4, ProductName = "PiknikuKurk" },
                new Product { ProductId = 33, CategoryID = 4, ProductName = "MagusKurk" }
                );

        }
    }
}
