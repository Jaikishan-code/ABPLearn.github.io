using System;
using System.Threading.Tasks;
using TestABP.Students;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace TestABP.EntityFrameworkCore.Students;

public class StudentRepositoryTests : TestABPEntityFrameworkCoreTestBase
{
    private readonly IStudentRepository _studentRepository;

    public StudentRepositoryTests()
    {
        _studentRepository = GetRequiredService<IStudentRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
