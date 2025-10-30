using Microsoft.EntityFrameworkCore;
using InvestOnIdeas.API.Models;

namespace InvestOnIdeas.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Idea> Ideas { get; set; } = null!;
        public DbSet<Collaboration> Collaborations { get; set; } = null!;
    }
}
