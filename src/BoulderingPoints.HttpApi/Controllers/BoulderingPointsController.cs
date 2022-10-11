using BoulderingPoints.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BoulderingPoints.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BoulderingPointsController : AbpControllerBase
{
    protected BoulderingPointsController()
    {
        LocalizationResource = typeof(BoulderingPointsResource);
    }
}
