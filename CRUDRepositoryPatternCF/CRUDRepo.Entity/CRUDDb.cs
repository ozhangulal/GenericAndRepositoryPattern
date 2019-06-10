using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CRUDRepo.Entity
{
    public class CRUDDb:DbContext
    {
        public CRUDDb()
        {
            base.Database.Connection.ConnectionString = @"server=localhost\SQLEXPRESS;database=CRUDDbCFSample;Integrated Security=SSPI;Trusted_Connection=True";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
