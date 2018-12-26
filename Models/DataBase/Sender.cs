using System;
using System.Collections.Generic;

namespace LAB9.Models.Database
{
    public partial class Sender
    {
        public Sender()
        {
            MessageFrom = new HashSet<Message>();
            MessageTo = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string JobPosition { get; set; }

        public ICollection<Message> MessageFrom { get; set; }
        public ICollection<Message> MessageTo { get; set; }
    }
}
