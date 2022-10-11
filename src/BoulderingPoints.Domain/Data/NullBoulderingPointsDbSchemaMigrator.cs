using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BoulderingPoints.Data;

/* This is used if database provider does't define
 * IBoulderingPointsDbSchemaMigrator implementation.
 */
public class NullBoulderingPointsDbSchemaMigrator : IBoulderingPointsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
