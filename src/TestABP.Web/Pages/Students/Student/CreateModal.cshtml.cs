using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestABP.Students;
using TestABP.Students.Dtos;
using TestABP.Web.Pages.Students.Student.ViewModels;

namespace TestABP.Web.Pages.Students.Student;

public class CreateModalModel : TestABPPageModel
{
    [BindProperty]
    public CreateEditStudentViewModel ViewModel { get; set; }

    private readonly IStudentAppService _service;

    public CreateModalModel(IStudentAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditStudentViewModel, CreateUpdateStudentDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}