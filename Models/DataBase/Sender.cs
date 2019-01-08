using System;
using System.Collections.Generic;

namespace KR.Models.Database
{
    public partial class Sender
    {
        public Sender()
        {
            Comment = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public ICollection<Comment> Comment { get; set; }
    }
}
