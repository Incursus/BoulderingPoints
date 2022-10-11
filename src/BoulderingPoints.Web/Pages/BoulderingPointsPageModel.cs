using BoulderingPoints.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BoulderingPoints.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BoulderingPointsPageModel : AbpPageModel
{
    protected BoulderingPointsPageModel()
    {
        LocalizationResourceType = typeof(BoulderingPointsResource);
    }
}
