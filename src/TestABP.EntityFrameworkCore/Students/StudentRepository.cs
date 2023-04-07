using System;
using System.Linq;
using System.Threading.Tasks;
using TestABP.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace TestABP.Students;

public class StudentRepository : EfCoreRepository<TestABPDbContext, Student, Guid>, IStudentRepository
{
    public StudentRepository(IDbContextProvider<TestABPDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Student>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}