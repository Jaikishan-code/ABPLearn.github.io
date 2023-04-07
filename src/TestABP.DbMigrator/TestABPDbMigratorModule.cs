using TestABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TestABP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestABPEntityFrameworkCoreModule),
    typeof(TestABPApplicationContractsModule)
    )]
public class TestABPDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
