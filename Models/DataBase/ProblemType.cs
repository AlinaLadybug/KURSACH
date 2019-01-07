using System;
using System.Collections.Generic;

namespace KR.Models.Database
{
    public partial class ProblemType
    {
        public ProblemType()
        {
            Problem = new HashSet<Problem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Problem> Problem { get; set; }
    }
}
