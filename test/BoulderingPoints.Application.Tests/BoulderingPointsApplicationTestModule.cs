using Volo.Abp.Modularity;

namespace BoulderingPoints;

[DependsOn(
    typeof(BoulderingPointsApplicationModule),
    typeof(BoulderingPointsDomainTestModule)
    )]
public class BoulderingPointsApplicationTestModule : AbpModule
{

}
