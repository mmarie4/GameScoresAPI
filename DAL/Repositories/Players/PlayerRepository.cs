using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Players
{
    public class PlayerRepository : IPlayerRepository
    {

        GameContext _context;
        public PlayerRepository(GameContext context)
        {
            _context = context;
        }

        public async Task<Player> GetPlayerByDeviceId(string deviceId) {
            return await _context.Players.FirstOrDefaultAsync(p => p.DeviceId == deviceId);
        }

        public async Task CreatePlayerAsync(Player playerToCreate) {
            await _context.Players.AddAsync(playerToCreate);
            _context.SaveChanges();
        }

        public void RemovePlayerAsync(Player playerToRemove)
        {
            _context.Players.Remove(playerToRemove);
            _context.SaveChanges();
        }

    }
}
