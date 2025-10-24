using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Models
{
    internal class CommentModel
    {
        public int CommentId { get; set; }

        public int IdeaId { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
