using System.Threading.Tasks;

namespace BoulderingPoints.Data;

public interface IBoulderingPointsDbSchemaMigrator
{
    Task MigrateAsync();
}
