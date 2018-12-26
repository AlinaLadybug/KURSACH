using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class Agrotechnic
    {
        public Agrotechnic()
        {
            Requirement = new HashSet<Requirement>();
            Roadmap = new HashSet<Roadmap>();
        }

        public int CarId { get; set; }
        public int? EmployeeId { get; set; }
        public int? TypeId { get; set; }

        public Employee Employee { get; set; }
        public AgrotechnicType Type { get; set; }
        public ICollection<Requirement> Requirement { get; set; }
        public ICollection<Roadmap> Roadmap { get; set; }
    }
}
