using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestABP.Products;
using TestABP.Products.Dtos;
using TestABP.Web.Pages.Products.Product.ViewModels;

namespace TestABP.Web.Pages.Products.Product;

public class EditModalModel : TestABPPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditProductViewModel ViewModel { get; set; }

    private readonly IProductAppService _service;

    public EditModalModel(IProductAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<ProductDto, CreateEditProductViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}