using System;
using Volo.Abp.Domain.Repositories;

namespace TestABP.Products;

public interface IProductRepository : IRepository<Product, Guid>
{
}
