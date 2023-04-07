using TestABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestABP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestABPController : AbpControllerBase
{
    protected TestABPController()
    {
        LocalizationResource = typeof(TestABPResource);
    }
}
