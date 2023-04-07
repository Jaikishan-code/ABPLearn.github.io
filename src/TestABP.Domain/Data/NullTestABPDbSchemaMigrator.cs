using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestABP.Data;

/* This is used if database provider does't define
 * ITestABPDbSchemaMigrator implementation.
 */
public class NullTestABPDbSchemaMigrator : ITestABPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
