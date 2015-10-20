namespace Lagersystem.Migrations
{
    using Lagersystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lagersystem.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Lagersystem.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Products.AddOrUpdate(
              p => p.Name,
              new Product { Name = "MSI GeForce GTX 970 Gaming 4GB", Price = 3790m, 
                  Category = "Electronics", Shelf = "22B", Count = 34, 
                  Description = "PCI-Express 3.0, \"Twin Frozr V\", D-DVI-I + DL-DVI-D, HDMI 2.0, DP",
                            ModifiedDate = DateTime.Today.AddDays(-4).Date,
                            PictureURL = "http://lorempixel.com/100/100"
              },
              new Product { Name = "Steelseries Rival Optical Mouse", Price = 599m, 
                  Category = "Electronics", Shelf = "6C", Count = 22, 
                  Description = "Gaming mus, trådbunden, optisk, 6500dpi",
                            ModifiedDate = DateTime.Today.AddDays(-12).Date,
                            PictureURL = "http://lorempixel.com/100/100"
              },
              new Product { Name = "Asus 24\" LED VG248QE", Price = 3290m, 
                  Category = "Electronics", Shelf = "790A", Count = 12, 
                  Description = "1920x1080, 144hz, 1ms, 80m:1, Speakers, DVI/HDMI/DP",
                            ModifiedDate = DateTime.Today.AddDays(-22).Date,
                            PictureURL = "http://lorempixel.com/100/100"
              },
              new Product { Name = "Arla Mellanmjölk", Price = 9.80m, 
                  Category = "Foodstuff", Shelf = "31G", Count = 490, 
                  Description = "1 liter tetra", ModifiedDate = DateTime.Today.Date,
                            PictureURL = "http://lorempixel.com/100/100"
              },
              new Product { Name = "Arla Vispgrädde", Price = 18.90m, Category = "Foodstuff", 
                  Shelf = "31A", Count = 67, Description = "0.5 liter tetra", 
                  ModifiedDate = DateTime.Today.AddDays(-1).Date, PictureURL = "http://lorempixel.com/100/100" }
            );
            
        }
    }
}
