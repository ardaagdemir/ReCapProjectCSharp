using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarProjectContext : DbContext //Base sınıf
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            //sql server connection
            optionbuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB=CarProject; Trusted_Connection=true"); //trusted connection = kullanıcı adı ve şifresiz giriş
                                            //yukarıdaki string yapısı = Connection String
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Cars"); 
        }
    }
}
