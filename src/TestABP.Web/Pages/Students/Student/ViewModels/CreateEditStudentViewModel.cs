using System;
using System.ComponentModel.DataAnnotations;

namespace TestABP.Web.Pages.Students.Student.ViewModels;

public class CreateEditStudentViewModel
{
    [Display(Name = "Name")]
    public string Name { get; set; }

    [Display(Name = "Address")]
    public string Address { get; set; }

    [Display(Name = "City")]
    public string City { get; set; }

    [Display(Name = "State")]
    public string State { get; set; }

    [Display(Name = "PinCode")]
    public string Postalcode { get; set; }

    [Display(Name = "Date of Birth")]
    public DateTime DOB { get; set; }


}
