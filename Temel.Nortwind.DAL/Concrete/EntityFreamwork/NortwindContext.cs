using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Temel.Nortwind.Entities.Concrete;

namespace Temel.Nortwind.DAL.Concrete.EntityFreamwork
{
   public class NortwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-U3DIVQ2\AURA;Initial Catalog=NORTHWND; User Id=sa; Password=artemis1132;Integrated Security=false;");
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-U3DIVQ2\SQLEXPRESS;Initial Catalog=NORTWND;User Id=Abdullah;Password=123456789;Integrated Security=false");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
