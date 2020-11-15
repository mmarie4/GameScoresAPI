using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;

namespace Services.Scores
{
    public interface IScoreService
    {
        Task<IEnumerable<Score>> GetScoresByDeviceIdAsync(string playerDeviceId);
        Task<Score> GetBestScoreByDeviceIdAndFieldAsync(string playerDeviceId, string field);
    }
}
