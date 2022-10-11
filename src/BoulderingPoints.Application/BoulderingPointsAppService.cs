using System;
using System.Collections.Generic;
using System.Text;
using BoulderingPoints.Localization;
using Volo.Abp.Application.Services;

namespace BoulderingPoints;

/* Inherit your application services from this class.
 */
public abstract class BoulderingPointsAppService : ApplicationService
{
    protected BoulderingPointsAppService()
    {
        LocalizationResource = typeof(BoulderingPointsResource);
    }
}
