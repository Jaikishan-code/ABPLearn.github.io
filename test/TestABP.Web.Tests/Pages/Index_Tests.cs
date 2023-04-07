using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TestABP.Pages;

public class Index_Tests : TestABPWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
