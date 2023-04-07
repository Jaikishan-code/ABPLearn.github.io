using System;
using System.ComponentModel.DataAnnotations;

namespace TestABP.Web.Pages.Products.Product.ViewModels;

public class CreateEditProductViewModel
{
    [Display(Name = "Product Name")]
    public string Product_Name { get; set; }

    [Display(Name = "Product Description")]
    public string Product_Description { get; set; }

    [Display(Name = "Product Category")]
    public string Product_Category { get; set; }

    [Display(Name = "Product Code")]
    public int Product_code { get; set; }

    [Display(Name = "Product Keywords")]
    public string Product_keywords { get; set; }

    [Display(Name = "Product Price")]
    public int Product_Price { get; set; }
}
