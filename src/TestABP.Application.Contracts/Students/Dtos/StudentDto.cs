using System;
using Volo.Abp.Application.Dtos;

namespace TestABP.Students.Dtos;

[Serializable]
public class StudentDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public int Postalcode { get; set; }

    public DateTime DOB { get; set; }
}