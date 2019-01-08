using KR.Models.Database;

namespace KR.Models.ViewModel
{
    public class SenderVm
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int CommentCount { get; set; }
        public string Position { get; set; }
    }
}