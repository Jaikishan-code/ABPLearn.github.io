using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace TestABP.Web.Pages.Products.Product;

public class IndexModel : TestABPPageModel
{
    public ProductFilterInput ProductFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class ProductFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProductProduct_Name")]
    public string Product_Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProductProduct_Description")]
    public string Product_Description { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProductProduct_Category")]
    public string Product_Category { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProductProduct_code")]
    public int? Product_code { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProductProduct_keywords")]
    public string Product_keywords { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "ProductProduct_Price")]
    public int? Product_Price { get; set; }
}
