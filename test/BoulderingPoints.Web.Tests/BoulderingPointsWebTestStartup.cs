using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace BoulderingPoints;

public class BoulderingPointsWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<BoulderingPointsWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
