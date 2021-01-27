using DAL.Entities;

namespace DAL.Repositories.Scores
{
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        public ScoreRepository(GameContext context) : base(context)
        {
        }
    }
}
