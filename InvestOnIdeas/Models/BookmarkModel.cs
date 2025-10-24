using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Models
{
    internal class BookmarkModel
    {
        public int BookmarkId { get; set; }
        public int IdeaId { get; set; }
        public int UserId { get; set; }
    }
}
