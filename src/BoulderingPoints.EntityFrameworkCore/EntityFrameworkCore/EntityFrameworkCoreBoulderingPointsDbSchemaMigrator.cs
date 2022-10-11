using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BoulderingPoints.Data;
using Volo.Abp.DependencyInjection;

namespace BoulderingPoints.EntityFrameworkCore;

public class EntityFrameworkCoreBoulderingPointsDbSchemaMigrator
    : IBoulderingPointsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBoulderingPointsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BoulderingPointsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BoulderingPointsDbContext>()
            .Database
            .MigrateAsync();
    }
}
