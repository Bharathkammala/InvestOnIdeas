using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Models
{
    internal class IdeaModel
    {
        public int IdeaId { get; set; }
        public string Title { get; set; } = string.Empty;

        public int CreatedBy { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
