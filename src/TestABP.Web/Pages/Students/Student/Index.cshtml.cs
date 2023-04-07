using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace TestABP.Web.Pages.Students.Student;

public class IndexModel : TestABPPageModel
{
    public StudentFilterInput StudentFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class StudentFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "Full Name")]
    public string Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "Address")]
    public string Address { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "City")]
    public string City { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "State")]
    public string State { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "Pincode")]
    public int Postalcode { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "Date of Birth")]
    public DateTime DOB { get; set; }
}
