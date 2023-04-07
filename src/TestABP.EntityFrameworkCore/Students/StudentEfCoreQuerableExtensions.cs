using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TestABP.Students;

public static class StudentEfCoreQueryableExtensions
{
    public static IQueryable<Student> IncludeDetails(this IQueryable<Student> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
