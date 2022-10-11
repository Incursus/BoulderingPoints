using BoulderingPoints.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BoulderingPoints;

[DependsOn(
    typeof(BoulderingPointsEntityFrameworkCoreTestModule)
    )]
public class BoulderingPointsDomainTestModule : AbpModule
{

}
