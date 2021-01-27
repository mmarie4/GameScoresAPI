using System.Diagnostics.CodeAnalysis;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GameContext : DbContext
    {
        public GameContext([NotNull] DbContextOptions<GameContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Score> Scores { get; set; }

    }
}
