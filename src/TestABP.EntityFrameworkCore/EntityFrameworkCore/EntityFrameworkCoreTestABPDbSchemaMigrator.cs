using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestABP.Data;
using Volo.Abp.DependencyInjection;

namespace TestABP.EntityFrameworkCore;

public class EntityFrameworkCoreTestABPDbSchemaMigrator
    : ITestABPDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTestABPDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TestABPDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TestABPDbContext>()
            .Database
            .MigrateAsync();
    }
}
