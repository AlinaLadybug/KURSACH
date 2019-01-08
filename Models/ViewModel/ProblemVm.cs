using KR.Models.Database;

namespace KR.Models.ViewModel
{
    public class ProblemVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public int TypeId { get; set; }
    }
}