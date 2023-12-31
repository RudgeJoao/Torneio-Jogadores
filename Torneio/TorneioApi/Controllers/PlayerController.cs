using Microsoft.AspNetCore.Mvc;
using TorneioApi.Domain;
using TorneioApi.Repositories;

namespace TorneioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpGet]
        public async Task<List<Player>> GetPlayers() 
        {
           var query = await _playerRepository.GetPlayers();
           return query;
        }
    }
}
