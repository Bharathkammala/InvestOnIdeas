using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Models
{
    internal class LikeModel
    {
        public int IdeaId { get; set; }
        public int UserId { get; set; }
        public int LikeId { get; set; }
    }
}
