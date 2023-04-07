using Volo.Abp.Modularity;

namespace TestABP;

[DependsOn(
    typeof(TestABPApplicationModule),
    typeof(TestABPDomainTestModule)
    )]
public class TestABPApplicationTestModule : AbpModule
{

}
