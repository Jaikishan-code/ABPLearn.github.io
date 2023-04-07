using TestABP.Students.Dtos;
using TestABP.Web.Pages.Students.Student.ViewModels;
using TestABP.Products.Dtos;
using TestABP.Web.Pages.Products.Product.ViewModels;
using AutoMapper;

namespace TestABP.Web;

public class TestABPWebAutoMapperProfile : Profile
{
    public TestABPWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<StudentDto, CreateEditStudentViewModel>();
        CreateMap<CreateEditStudentViewModel, CreateUpdateStudentDto>();
        CreateMap<ProductDto, CreateEditProductViewModel>();
        CreateMap<CreateEditProductViewModel, CreateUpdateProductDto>();
    }
}
