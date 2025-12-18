using Application.Interfaces.Repositories;
using Infrastructure.Repositories;

namespace PokemonApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPokemonRepository, PokemonRepository>();
            return services;
        }
    }
}
