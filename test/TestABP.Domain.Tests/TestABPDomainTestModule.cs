using TestABP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TestABP;

[DependsOn(
    typeof(TestABPEntityFrameworkCoreTestModule)
    )]
public class TestABPDomainTestModule : AbpModule
{

}
