using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Services.Models;

namespace Services.Players
{
    public interface IPlayerService
    {
        Task<Player> GetPlayerAsync(string playerDeviceId);
        Task<Result> CreatePlayerAsync(PlayerCreateParameter parameter);
        Task<Result> UpdatePlayerAsync(PlayerUpdateParameter parameter);
        Task<Result> DeletePlayerAsync(string playerDeviceId);

        Task<IEnumerable<Player>> GetAllAsync(int limit, int offset);
    }
}
