using System;
using Volo.Abp.Domain.Repositories;

namespace TestABP.Students;

public interface IStudentRepository : IRepository<Student, Guid>
{
}
