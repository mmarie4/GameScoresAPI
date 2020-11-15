﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Models;
using Services.Players;

namespace EndlessFallAPI.Controllers
{
    [ApiController]
    [Route("players")]
    public class PlayerController : ControllerBase
    {

        private readonly ILogger<PlayerController> _logger;
        private readonly IPlayerService _playerService;

        public PlayerController(ILogger<PlayerController> logger, IPlayerService playerService)
        {
            _logger = logger;
            _playerService = playerService;
        }

        /// <summary>
        /// Get all players with pagination
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IEnumerable<Player>> GetAll([FromQuery] int limit, int offset)
        {
            return await _playerService.GetAllAsync(limit, offset);
        }

        /// <summary>
        /// Get a player using device id
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [HttpGet("device-id/{deviceId}")]
        public async Task<Player> GetPlayer([FromRoute] string deviceId)
        {
            return await _playerService.GetPlayerAsync(deviceId);
        }

        /// <summary>
        /// Create a player
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<Result> CreatePlayer([FromBody] PlayerCreateParameter parameter) {
            return await _playerService.CreatePlayerAsync(parameter);
        }

        /// <summary>
        /// Updates a player
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [HttpPut("")]
        public async Task<Result> UpdatePlayer([FromBody] PlayerUpdateParameter parameter)
        {
            return await _playerService.UpdatePlayerAsync(parameter);
        }

        /// <summary>
        /// Deletes a plqyer using the device id
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [HttpDelete("device-id/{deviceId}")]
        public async Task<Result> DeletePlayer([FromBody] string deviceId)
        {
            return await _playerService.DeletePlayerAsync(deviceId);
        }
    }
}
