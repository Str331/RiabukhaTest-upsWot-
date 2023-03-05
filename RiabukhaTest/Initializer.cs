using upswot.Services.Implementation;
using upswot.Services.Service_Interface;

namespace RiabukhaTest
{
    public static class Initializer
    {
        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<ICharacterService, CharacterService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IEpisodeService, EpisodeService>();
        }
    }
}
