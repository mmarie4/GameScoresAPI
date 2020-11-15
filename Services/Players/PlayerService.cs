using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Players;
using Services.Models;

namespace Services.Players
{
    public class PlayerService
    {

        private readonly IPlayerRepository _playerRepository;


        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<Player> GetPlayerAsync(string playerDeviceId) {
            return await _playerRepository.GetPlayerByDeviceId(playerDeviceId);
        }


        public async Task CreatePlayerAsync(PlayerCreateParameter parameter)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePlayerAsync(PlayerUpdateParameter parameter) {
            throw new NotImplementedException();
        }

        public async Task DeletePlayerAsync(string playerDeviceId) {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Player>> GetAllAsync(int limit, int offset) {
            throw new NotImplementedException();
        }
    }
}
