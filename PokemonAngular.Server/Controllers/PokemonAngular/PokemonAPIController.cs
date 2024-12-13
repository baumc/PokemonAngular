using Microsoft.AspNetCore.Mvc;
using PokeApiNet;

namespace PokemonAngular.Server.Controllers.PokemonAngular
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonAPIController : ControllerBase
    {
        private readonly ILogger<PokemonAPIController> _logger;
        private PokeApiClient _pokeApiClient = new PokeApiClient();

        public PokemonAPIController(ILogger<PokemonAPIController> logger) { _logger = logger; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Pokemon pikachu = await _pokeApiClient.GetResourceAsync<Pokemon>("pikachu");
            return Ok(pikachu);
        }
    }
}
