using System;
using System.Collections.Generic;

namespace LAB9.Models.Database
{
    public partial class Problem
    {
        public Problem()
        {
            Message = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? Created { get; set; }

        public ICollection<Message> Message { get; set; }
    }
}
