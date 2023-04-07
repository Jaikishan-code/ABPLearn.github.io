using System;
using System.Collections.Generic;
using System.Text;
using TestABP.Localization;
using Volo.Abp.Application.Services;

namespace TestABP;

/* Inherit your application services from this class.
 */
public abstract class TestABPAppService : ApplicationService
{
    protected TestABPAppService()
    {
        LocalizationResource = typeof(TestABPResource);
    }
}
