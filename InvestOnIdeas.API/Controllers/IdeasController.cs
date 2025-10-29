using Microsoft.AspNetCore.Mvc;
using InvestOnIdeas.API.Data;
using InvestOnIdeas.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestOnIdeas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdeasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public IdeasController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetIdeas() => Ok(await _context.Ideas.ToListAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIdea(int id)
        {
            var idea = await _context.Ideas.FindAsync(id);
            if (idea == null) return NotFound();
            return Ok(idea);
        }

        [HttpPost]
        public async Task<IActionResult> AddIdea(Idea idea)
        {
            _context.Ideas.Add(idea);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetIdea), new { id = idea.IdeaID }, idea);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIdea(int id, Idea idea)
        {
            var dbIdea = await _context.Ideas.FindAsync(id);
            if (dbIdea == null) return NotFound();

            dbIdea.Title = idea.Title;
            dbIdea.Description = idea.Description;
            dbIdea.Category = idea.Category;
            dbIdea.FundingRequired = idea.FundingRequired;

            await _context.SaveChangesAsync();
            return Ok(dbIdea);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIdea(int id)
        {
            var dbIdea = await _context.Ideas.FindAsync(id);
            if (dbIdea == null) return NotFound();

            _context.Ideas.Remove(dbIdea);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
