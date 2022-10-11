using BoulderingPoints.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BoulderingPoints.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BoulderingPointsEntityFrameworkCoreModule),
    typeof(BoulderingPointsApplicationContractsModule)
    )]
public class BoulderingPointsDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
