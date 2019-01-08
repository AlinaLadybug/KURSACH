using System;
using KR.Models.Database;

namespace KR.Models.ViewModel
{
    public class CommentVm
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string SenderName { get; set; }
        public DateTime Date { get; set; }
        public string ProblemTitle { get; set; }
        public int ProblemId { get; set; }
        public int SenderId { get; set; }
        public SenderVm[] Senders { get; set; }

    }
}