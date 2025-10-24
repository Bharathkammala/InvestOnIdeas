using InvestOnIdeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Services
{
    internal class BookmarkService
    {
        private readonly List<BookmarkModel> bookmarks = new();

        public async Task AddBookmarkAsync(int ideaId, int userId)
        {
            await Task.Delay(100);
            if (!bookmarks.Any(b => b.IdeaId == ideaId && b.UserId == userId))
                bookmarks.Add(new BookmarkModel { BookmarkId = bookmarks.Count + 1, IdeaId = ideaId, UserId = userId });
        }

        public async Task RemoveBookmarkAsync(int ideaId, int userId)
        {
            await Task.Delay(100);
            var bookmark = bookmarks.FirstOrDefault(b => b.IdeaId == ideaId && b.UserId == userId);
            if (bookmark != null)
                bookmarks.Remove(bookmark);
        }

        public async Task<List<BookmarkModel>> GetBookmarksByUserAsync(int userId)
        {
            await Task.Delay(100);
            return bookmarks.Where(b => b.UserId == userId).ToList();
        }
    }
}
