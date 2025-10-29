namespace InvestOnIdeas.API.Models
{
    public class Idea
    {
        public int IdeaID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal FundingRequired { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
