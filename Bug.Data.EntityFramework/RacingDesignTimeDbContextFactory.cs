using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Bug.Data.EntityFramework
{
    class RacingDesignTimeDbContextFactory : IDesignTimeDbContextFactory<RacingDbContext>
    {
        public RacingDbContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("RacingDbContext");

            var optionsBuilder = new DbContextOptionsBuilder<RacingDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            var options = optionsBuilder.Options;
            return new RacingDbContext(options);
        }
    }
}
