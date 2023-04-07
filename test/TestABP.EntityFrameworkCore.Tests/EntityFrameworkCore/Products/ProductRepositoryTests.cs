using System;
using System.Threading.Tasks;
using TestABP.Products;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace TestABP.EntityFrameworkCore.Products;

public class ProductRepositoryTests : TestABPEntityFrameworkCoreTestBase
{
    private readonly IProductRepository _productRepository;

    public ProductRepositoryTests()
    {
        _productRepository = GetRequiredService<IProductRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
