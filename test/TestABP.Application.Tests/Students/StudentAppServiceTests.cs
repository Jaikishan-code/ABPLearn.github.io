using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace TestABP.Students;

public class StudentAppServiceTests : TestABPApplicationTestBase
{
    private readonly IStudentAppService _studentAppService;

    public StudentAppServiceTests()
    {
        _studentAppService = GetRequiredService<IStudentAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

