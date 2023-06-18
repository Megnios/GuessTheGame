using GuessTheGame.Models;
using Microsoft.EntityFrameworkCore;

namespace GuessTheGame.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }
        public DbSet<Game> Games { get; set; }
    }
}
