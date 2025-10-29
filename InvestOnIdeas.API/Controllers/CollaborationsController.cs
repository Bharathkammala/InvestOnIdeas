using Microsoft.AspNetCore.Mvc;
using InvestOnIdeas.API.Data;
using InvestOnIdeas.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestOnIdeas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaborationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CollaborationsController(AppDbContext context) => _context = context;

        [HttpPost]
        public async Task<IActionResult> AddCollaboration(Collaboration collab)
        {
            _context.Collaborations.Add(collab);
            await _context.SaveChangesAsync();
            return Ok(collab);
        }

        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetByUser(int id)
        {
            var list = await _context.Collaborations.Where(c => c.InvestorID == id).ToListAsync();
            return Ok(list);
        }

        [HttpGet("idea/{id}")]
        public async Task<IActionResult> GetByIdea(int id)
        {
            var list = await _context.Collaborations.Where(c => c.IdeaID == id).ToListAsync();
            return Ok(list);
        }
    }
}
