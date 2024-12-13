using PokeApiNet;

namespace PokemonAngular.Server.Services
{
    public class PokemonAPIService
    {
        private static readonly Lazy<PokeApiClient> lazyPokeApiClient = new Lazy<PokeApiClient>(() =>
            {
                return new PokeApiClient();               
            });
        private PokemonAPIService() { }

        public static PokeApiClient Client => lazyPokeApiClient.Value;
    }
}
