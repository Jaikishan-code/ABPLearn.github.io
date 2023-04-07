using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace TestABP.Products.Dtos;

[Serializable]
public class ProductGetListInput : PagedAndSortedResultRequestDto
{
    public string Product_Name { get; set; }

    public string Product_Description { get; set; }

    public string Product_Category { get; set; }

    public int? Product_code { get; set; }

    public string Product_keywords { get; set; }

    public int? Product_Price { get; set; }
}