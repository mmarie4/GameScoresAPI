using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Services.Models;

namespace Services.Players
{
    public interface IPlayerService
    {
        Task<Player> GetPlayerAsync(string playerDeviceId);
        Task<Player> CreatePlayerAsync(PlayerCreateParameter parameter);
        Task<Player> UpdatePlayerAsync(PlayerUpdateParameter parameter);
        Task<Player> DeletePlayerAsync(string playerDeviceId);

        Task<IEnumerable<Player>> GetAllAsync(int limit, int offset);
    }
}
