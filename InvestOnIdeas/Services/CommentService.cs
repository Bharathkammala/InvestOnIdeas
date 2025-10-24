using InvestOnIdeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Services
{
    internal class CommentService
    {
        private readonly List<CommentModel> comments = new();

        public async Task AddCommentAsync(int ideaId, int userId, string text)
        {
            await Task.Delay(100);
            comments.Add(new CommentModel
            {
                CommentId = comments.Count + 1,
                IdeaId = ideaId,
                UserId = userId,
                CommentText = text,
                CreatedAt = DateTime.Now
            });
        }

        public async Task<List<CommentModel>> GetCommentsByIdeaAsync(int ideaId)
        {
            await Task.Delay(100);
            return comments.Where(c => c.IdeaId == ideaId).ToList();
        }
    }
}
