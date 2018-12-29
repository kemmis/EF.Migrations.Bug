using System;
using System.Collections.Generic;
using System.Text;
using Bug.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Bug.Data.EntityFramework
{
    class RacingDbContext : DbContext
    {
        public RacingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceDriver>()
                .HasKey(rd => new {rd.RaceId, rd.DriverId});

            base.OnModelCreating(modelBuilder);
        }
    }
}
