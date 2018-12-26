using System;
using System.Collections.Generic;

namespace LAB9.Models.Database
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime? Sent { get; set; }
        public int? FromId { get; set; }
        public int? ToId { get; set; }
        public int? ProblemId { get; set; }

        public Sender From { get; set; }
        public Problem Problem { get; set; }
        public Sender To { get; set; }
    }
}
