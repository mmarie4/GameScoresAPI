using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Scores;

namespace EndlessFallAPI.Controllers
{
    [ApiController]
    [Route("scores")]
    public class ScoreController : ControllerBase
    {

        private readonly ILogger<PlayerController> _logger;
        private readonly IScoreService _scoreService;

        public ScoreController(ILogger<PlayerController> logger, IScoreService scoreService)
        {
            _logger = logger;
            _scoreService = scoreService;
        }

        /// <summary>
        /// Get all scores of a player, by device id
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        [HttpGet("device/{devicedId}")]
        public async Task<IEnumerable<Score>> GetScoresAsync(string deviceId)
        {
            return await _scoreService.GetScoresByDeviceIdAsync(deviceId);
        }

        /// <summary>
        /// Get only the best score of a player, by device id and field
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="field">The field parameter : distance, coins, duration</param>
        /// <returns></returns>
        [HttpGet("device/{devicedId}/best-score")]
        public async Task<Score> GetBestScoreByFieldAsync(string deviceId, [FromQuery] string field)
        {
            return await _scoreService.GetBestScoreByDeviceIdAndFieldAsync(deviceId, field);
        }
    }
}
