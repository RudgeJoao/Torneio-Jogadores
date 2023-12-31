using TorneioApi.Domain;

namespace TorneioApi.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetPlayers();
    }
}
