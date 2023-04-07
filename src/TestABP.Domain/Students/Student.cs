using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace TestABP.Students
{
    public class Student : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Postalcode { get; set; }

        public DateTime DOB { get; set; }

        protected Student()
        {
        }

        public Student(
            Guid id,
            string name,
            string address,
            string city,
            string state,
            int postalcode,
            DateTime dob
        ) : base(id)
        {
            Name = name;
            Address = address;
            City = city;

            State = state;
            Postalcode = postalcode;
            DOB = dob;
        }
    }
}
