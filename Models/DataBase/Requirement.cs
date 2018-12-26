using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class Requirement
    {
        public int RequirementId { get; set; }
        public DateTime Date { get; set; }
        public decimal? Sum { get; set; }
        public int? CarId { get; set; }

        public Agrotechnic Car { get; set; }
    }
}
