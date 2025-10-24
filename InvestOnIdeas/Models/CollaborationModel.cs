using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Models
{
    internal class CollaborationModel
    {
        public int CollaborationId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }

        public string CollaborationNote { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; } = string.Empty;
        public int IdeaId { get; set; }

    }
}
