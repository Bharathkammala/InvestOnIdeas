using InvestOnIdeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Services
{
    internal class LikeService
    {
        private readonly List<LikeModel> likes = new();

        public async Task ToggleLikeAsync(int ideaId, int userId)
        {
            await Task.Delay(100);
            var like = likes.FirstOrDefault(l => l.IdeaId == ideaId && l.UserId == userId);
            if (like != null)
                likes.Remove(like);
            else
                likes.Add(new LikeModel { LikeId = likes.Count + 1, IdeaId = ideaId, UserId = userId });
        }

        public async Task<int> GetLikesCountAsync(int ideaId)
        {
            await Task.Delay(50);
            return likes.Count(l => l.IdeaId == ideaId);
        }
    }
}
