using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class Employee
    {
        public Employee()
        {
            Agrotechnic = new HashSet<Agrotechnic>();
        }

        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Passport { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Specialization { get; set; }
        public decimal? Salary { get; set; }
        public int? CommandId { get; set; }

        public Command Command { get; set; }
        public ICollection<Agrotechnic> Agrotechnic { get; set; }
    }
}
