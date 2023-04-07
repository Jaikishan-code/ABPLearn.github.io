using System;
using System.Linq;
using System.Threading.Tasks;
using TestABP.Permissions;
using TestABP.Students.Dtos;
using Volo.Abp.Application.Services;

namespace TestABP.Students;


public class StudentAppService : CrudAppService<Student, StudentDto, Guid, StudentGetListInput, CreateUpdateStudentDto, CreateUpdateStudentDto>,
    IStudentAppService
{
    protected override string GetPolicyName { get; set; } = TestABPPermissions.Student.Default;
    protected override string GetListPolicyName { get; set; } = TestABPPermissions.Student.Default;
    protected override string CreatePolicyName { get; set; } = TestABPPermissions.Student.Create;
    protected override string UpdatePolicyName { get; set; } = TestABPPermissions.Student.Update;
    protected override string DeletePolicyName { get; set; } = TestABPPermissions.Student.Delete;

    private readonly IStudentRepository _repository;

    public StudentAppService(IStudentRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Student>> CreateFilteredQueryAsync(StudentGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Address.IsNullOrWhiteSpace(), x => x.Address.Contains(input.Address))
            .WhereIf(!input.City.IsNullOrWhiteSpace(), x => x.City.Contains(input.City))
            ;
    }
}
