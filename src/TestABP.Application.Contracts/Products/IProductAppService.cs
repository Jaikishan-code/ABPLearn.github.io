using System;
using TestABP.Products.Dtos;
using Volo.Abp.Application.Services;

namespace TestABP.Products;

public interface IProductAppService :
    ICrudAppService< 
        ProductDto, 
        Guid, 
        ProductGetListInput,
        CreateUpdateProductDto,
        CreateUpdateProductDto>
{

}