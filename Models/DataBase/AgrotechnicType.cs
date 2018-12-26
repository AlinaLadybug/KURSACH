using System;
using System.Collections.Generic;

namespace LAB9.Models.DataBase
{
    public partial class AgrotechnicType
    {
        public AgrotechnicType()
        {
            Agrotechnic = new HashSet<Agrotechnic>();
        }

        public int TypeId { get; set; }
        public string Type { get; set; }

        public ICollection<Agrotechnic> Agrotechnic { get; set; }
    }
}
