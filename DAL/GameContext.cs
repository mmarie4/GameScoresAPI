using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class GameContext : DbContext
    {
        public GameContext()
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Score> Scores { get; set; }

    }
}
