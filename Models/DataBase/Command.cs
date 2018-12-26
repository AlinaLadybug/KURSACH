using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class Command
    {
        public Command()
        {
            Employee = new HashSet<Employee>();
        }

        public int CommandId { get; set; }
        public int? CropId { get; set; }
        public DateTime Date { get; set; }
        public decimal? Sum { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
