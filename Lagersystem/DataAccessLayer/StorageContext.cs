using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lagersystem.DataAccessLayer
{
    public class StorageContext : DbContext
    {
        public StorageContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Models.Product> Products { get; set; }
    }
}
