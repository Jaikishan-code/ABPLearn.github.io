using System;
using Volo.Abp.Application.Dtos;

namespace TestABP.Products.Dtos;

[Serializable]
public class ProductDto : FullAuditedEntityDto<Guid>
{
    public string Product_Name { get; set; }

    public string Product_Description { get; set; }

    public string Product_Category { get; set; }

    public int Product_code { get; set; }

    public string Product_keywords { get; set; }

    public int Product_Price { get; set; }
}