using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BoulderingPoints.Web;

[Dependency(ReplaceServices = true)]
public class BoulderingPointsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BoulderingPoints";
}
