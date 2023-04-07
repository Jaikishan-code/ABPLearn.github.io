using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace TestABP.Products;

public class ProductAppServiceTests : TestABPApplicationTestBase
{
    private readonly IProductAppService _productAppService;

    public ProductAppServiceTests()
    {
        _productAppService = GetRequiredService<IProductAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

