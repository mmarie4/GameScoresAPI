using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.Players
{
    public interface IPlayerRepository
    {
        Task<Player> GetPlayerByDeviceId(string deviceId);
        Task CreatePlayerAsync(Player playerToCreate);
        void RemovePlayerAsync(Player playerToRemove);
    }
}
