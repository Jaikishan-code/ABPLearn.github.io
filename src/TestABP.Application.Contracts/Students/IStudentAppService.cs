using System;
using TestABP.Students.Dtos;
using Volo.Abp.Application.Services;

namespace TestABP.Students;

public interface IStudentAppService :
    ICrudAppService< 
        StudentDto, 
        Guid, 
        StudentGetListInput,
        CreateUpdateStudentDto,
        CreateUpdateStudentDto>
{

}