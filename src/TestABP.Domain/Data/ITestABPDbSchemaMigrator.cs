using System.Threading.Tasks;

namespace TestABP.Data;

public interface ITestABPDbSchemaMigrator
{
    Task MigrateAsync();
}
