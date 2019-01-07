using System;
using System.Collections.Generic;

namespace KR.Models.Database
{
    public partial class Problem
    {
        public Problem()
        {
            Comment = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Status { get; set; }
        public int? TypeId { get; set; }

        public ProblemType Type { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}
