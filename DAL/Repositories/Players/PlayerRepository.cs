using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Players
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(GameContext context) : base(context)
        { 
        }

        public async Task<Player> GetPlayerByDeviceId(string deviceId) {
            return await Entities.FirstOrDefaultAsync(p => p.DeviceId == deviceId);
        }

    }
}
