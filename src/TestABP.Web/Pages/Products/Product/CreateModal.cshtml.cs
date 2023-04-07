using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestABP.Products;
using TestABP.Products.Dtos;
using TestABP.Web.Pages.Products.Product.ViewModels;

namespace TestABP.Web.Pages.Products.Product;

public class CreateModalModel : TestABPPageModel
{
    [BindProperty]
    public CreateEditProductViewModel ViewModel { get; set; }

    private readonly IProductAppService _service;

    public CreateModalModel(IProductAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}