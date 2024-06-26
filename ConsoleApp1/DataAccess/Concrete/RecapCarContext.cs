using Microsoft.EntityFrameworkCore;
using RecapProjectCar.Entities;
using RecapProjectCar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProjectCar.DataAccess.Concrete
{
    public class RecapCarContext:DbContext

    {
        private static readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RecapCar;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Entities.Concrete.Color> Colors { get; set; }
    }
}
