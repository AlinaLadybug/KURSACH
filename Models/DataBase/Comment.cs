using System;
using System.Collections.Generic;

namespace KR.Models.Database
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime? Date { get; set; }
        public int? ProblemId { get; set; }
        public int? SenderId { get; set; }

        public Problem Problem { get; set; }
        public Sender Sender { get; set; }
    }
}
