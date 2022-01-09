using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2_Garage.Models
{
    public partial class GarageContext : DbContext
    {
        public GarageContext()
            : base("name=GarageContext")
        {
        }

        public DbSet<Car> cars { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
