using Microsoft.EntityFrameworkCore;
using TorneioApi.Domain;

namespace TorneioApi.Data
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}
