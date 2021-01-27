using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.Players
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Task<Player> GetPlayerByDeviceId(string deviceId);
    }
}
