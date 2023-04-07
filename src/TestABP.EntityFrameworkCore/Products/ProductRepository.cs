using System;
using System.Linq;
using System.Threading.Tasks;
using TestABP.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace TestABP.Products;

public class ProductRepository : EfCoreRepository<TestABPDbContext, Product, Guid>, IProductRepository
{
    public ProductRepository(IDbContextProvider<TestABPDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Product>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}