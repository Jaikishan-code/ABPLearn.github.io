using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestABP.Students;
using TestABP.Students.Dtos;
using TestABP.Web.Pages.Students.Student.ViewModels;

namespace TestABP.Web.Pages.Students.Student;

public class EditModalModel : TestABPPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditStudentViewModel ViewModel { get; set; }

    private readonly IStudentAppService _service;

    public EditModalModel(IStudentAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<StudentDto, CreateEditStudentViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditStudentViewModel, CreateUpdateStudentDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}