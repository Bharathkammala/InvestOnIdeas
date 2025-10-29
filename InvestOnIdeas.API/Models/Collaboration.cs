namespace InvestOnIdeas.API.Models
{
    public class Collaboration
    {
        public int CollabID { get; set; }
        public int InvestorID { get; set; }
        public int IdeaID { get; set; }
        public string? CollaborationNote { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
