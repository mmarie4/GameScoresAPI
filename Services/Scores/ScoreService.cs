using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Repositories.Scores;

namespace Services.Scores
{
    public class ScoreService : IScoreService
    {

        private readonly IScoreRepository _scoreRepository;

        public ScoreService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public async Task<IEnumerable<Score>> GetScoresByDeviceIdAsync(string playerDeviceId) {
            throw new NotImplementedException();
        }

        public async Task<Score> GetBestScoreByDeviceIdAndFieldAsync(string playerDeviceId, string field) {
            throw new NotImplementedException();
        }
    }
}
