using Microsoft.AspNetCore.Mvc;
using PokeApiNet;
using PokemonAngular.Server.Services;
using System.Text.Json;

namespace PokemonAngular.Server.Controllers.PokemonAngular
{
    [Route("[controller]")]
    [ApiController]
    public class VersionGroupController : ControllerBase
    {

        private readonly ILogger<VersionGroupController> _logger;

        public VersionGroupController(ILogger<VersionGroupController> logger)
        {
            _logger = logger;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            var pokeApiClient = PokemonAPIService.Client;
            var versionGroups = pokeApiClient.GetAllNamedResourcesAsync<VersionGroup>();
            var versionGroupsJSON = new List<VersionGroup>();
            await foreach(var versionGroup in pokeApiClient.GetAllNamedResourcesAsync<VersionGroup>())
            {
                versionGroupsJSON.Add(await pokeApiClient.GetResourceAsync<VersionGroup>(versionGroup.Name));
            }
            return Ok(versionGroupsJSON);
        }
    }
}
