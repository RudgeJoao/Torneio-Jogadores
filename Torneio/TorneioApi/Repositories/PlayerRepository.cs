using Microsoft.EntityFrameworkCore;
using TorneioApi.Data;
using TorneioApi.Domain;

namespace TorneioApi.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly OracleDbContext _dbContext;

        public PlayerRepository(OracleDbContext dbContext)
        {
            _dbContext = dbContext;
        } 
        
        public async Task<List<Player>> GetPlayers() 
        {
            var query = await _dbContext.Players.OrderBy(x=> x.Id).ToListAsync();
            return query;
        }
    }
}
