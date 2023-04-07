using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TestABP.Web;

[Dependency(ReplaceServices = true)]
public class TestABPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestABP";
}
