using System;
using System.Linq;
using System.Threading.Tasks;
using TestABP.Permissions;
using TestABP.Products.Dtos;
using Volo.Abp.Application.Services;

namespace TestABP.Products;


public class ProductAppService : CrudAppService<Product, ProductDto, Guid, ProductGetListInput, CreateUpdateProductDto, CreateUpdateProductDto>,
    IProductAppService
{
    protected override string GetPolicyName { get; set; } = TestABPPermissions.Product.Default;
    protected override string GetListPolicyName { get; set; } = TestABPPermissions.Product.Default;
    protected override string CreatePolicyName { get; set; } = TestABPPermissions.Product.Create;
    protected override string UpdatePolicyName { get; set; } = TestABPPermissions.Product.Update;
    protected override string DeletePolicyName { get; set; } = TestABPPermissions.Product.Delete;

    private readonly IProductRepository _repository;

    public ProductAppService(IProductRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Product>> CreateFilteredQueryAsync(ProductGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Product_Name.IsNullOrWhiteSpace(), x => x.Product_Name.Contains(input.Product_Name))
            .WhereIf(!input.Product_Description.IsNullOrWhiteSpace(), x => x.Product_Description.Contains(input.Product_Description))
            .WhereIf(!input.Product_Category.IsNullOrWhiteSpace(), x => x.Product_Category.Contains(input.Product_Category))
            .WhereIf(input.Product_code != null, x => x.Product_code == input.Product_code)
            .WhereIf(!input.Product_keywords.IsNullOrWhiteSpace(), x => x.Product_keywords.Contains(input.Product_keywords))
            .WhereIf(input.Product_Price != null, x => x.Product_Price == input.Product_Price)
            ;
    }
}
