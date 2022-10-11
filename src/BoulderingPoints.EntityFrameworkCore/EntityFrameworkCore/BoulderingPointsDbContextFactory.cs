using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BoulderingPoints.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BoulderingPointsDbContextFactory : IDesignTimeDbContextFactory<BoulderingPointsDbContext>
{
    public BoulderingPointsDbContext CreateDbContext(string[] args)
    {
        BoulderingPointsEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BoulderingPointsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BoulderingPointsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BoulderingPoints.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
