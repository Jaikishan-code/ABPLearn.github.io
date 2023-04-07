using TestABP.Students;
using TestABP.Students.Dtos;
using TestABP.Products;
using TestABP.Products.Dtos;
using AutoMapper;

namespace TestABP;

public class TestABPApplicationAutoMapperProfile : Profile
{
    public TestABPApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>(MemberList.Source);
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>(MemberList.Source);
    }
}
