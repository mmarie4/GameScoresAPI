using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Players;
using Services.Models;

namespace Services.Players
{
    public class PlayerService : IPlayerService
    {

        private readonly IPlayerRepository _playerRepository;


        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<Player> GetPlayerAsync(string playerDeviceId) {
            return await _playerRepository.GetPlayerByDeviceId(playerDeviceId);
        }


        public async Task<Player> CreatePlayerAsync(PlayerCreateParameter parameter)
        {
            var player = new Player()
            {
                Country = parameter.Country,
                DeviceId = parameter.DeviceId,
                Name = parameter.Name
            };
            var result = await _playerRepository.AddAsync(player);

            await _playerRepository.SaveAsync();
            return result;
        }

        public async Task<Player> UpdatePlayerAsync(PlayerUpdateParameter parameter) {
            throw new NotImplementedException();
        }

        public async Task<Player> DeletePlayerAsync(string playerDeviceId) {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Player>> GetAllAsync(int limit, int offset) {
            throw new NotImplementedException();
        }
    }
}
