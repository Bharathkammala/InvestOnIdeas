using InvestOnIdeas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestOnIdeas.Services
{
    internal class IdeaService
    {
        private readonly List<IdeaModel> ideas = new()
        {
            new IdeaModel { IdeaId = 1, Title = "AI Crop Health Monitor", Description = "AI system to detect crop disease early.", Category = "Agriculture", CreatedBy = 1 },
            new IdeaModel { IdeaId = 2, Title = "Smart Waste Management", Description = "IoT-enabled bins for city management.", Category = "Environment", CreatedBy = 2 },
            new IdeaModel { IdeaId = 3, Title = "Mental Health Chatbot", Description = "AI chatbot for emotional support.", Category = "Healthcare", CreatedBy = 1 }
        };

        public async Task<List<IdeaModel>> GetAllIdeasAsync()
        {
            await Task.Delay(150);
            return ideas;
        }

        public async Task<List<IdeaModel>> GetIdeasByUserAsync(int userId)
        {
            await Task.Delay(100);
            return ideas.Where(i => i.CreatedBy == userId).ToList();
        }

        public async Task AddIdeaAsync(IdeaModel idea)
        {
            await Task.Delay(100);
            idea.IdeaId = ideas.Max(i => i.IdeaId) + 1;
            ideas.Add(idea);
        }
    }
}
