using TestABP.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TestABP.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class TestABPPageModel : AbpPageModel
{
    protected TestABPPageModel()
    {
        LocalizationResourceType = typeof(TestABPResource);
    }
}
