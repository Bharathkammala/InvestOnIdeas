using InvestOnIdeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Services
{
    internal class CollaborationService
    {
        private readonly List<CollaborationModel> collaborations = new();

        public async Task<List<CollaborationModel>> GetCollaborationsByUserAsync(int userId)
        {
            await Task.Delay(100);
            return collaborations.Where(c => c.SenderId == userId || c.ReceiverId == userId).ToList();
        }

        public async Task RequestCollaborationAsync(int senderId, int ideaId, int receiverId, string note)
        {
            await Task.Delay(100);
            collaborations.Add(new CollaborationModel
            {
                CollaborationId = collaborations.Count + 1,
                SenderId = senderId,
                ReceiverId = receiverId,
                IdeaId = ideaId,
                Status = "Pending",
                CollaborationNote = note,
                CreatedAt = DateTime.Now
            });
        }

        public async Task UpdateStatusAsync(int collabId, string newStatus)
        {
            await Task.Delay(100);
            var collab = collaborations.FirstOrDefault(c => c.CollaborationId == collabId);
            if (collab != null)
                collab.Status = newStatus;
        }
    }
}
