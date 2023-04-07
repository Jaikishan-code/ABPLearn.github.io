using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace TestABP;

public class TestABPWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<TestABPWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
