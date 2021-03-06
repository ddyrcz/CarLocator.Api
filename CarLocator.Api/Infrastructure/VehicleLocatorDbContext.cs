using System;
using CarLocator.Api.Vehicles.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarLocator.Api.Infrastructure
{
    public class VehicleLocatorDbContext : DbContext
    {
        public VehicleLocatorDbContext(DbContextOptions<VehicleLocatorDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Vehicle>()
            //    .HasData(new Vehicle{Id = Guid.Parse("38e599d7-067e-45f1-b1bb-da3ee309f169") , Name = "IVECO WW 12345"  , MostRecentLocation = new Location() { Lat = 12.3245, Lon = 55.1234 } });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}