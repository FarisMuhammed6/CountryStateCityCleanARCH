using CountryStateCity.Domain.Interface;
using CountryStateCity.Domain.Interface.Queries.Maters;
using CountryStateCity.Infrastructure.Data;
using CountryStateCity.Infrastructure.Queries;
using CountryStateCity.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CountryStateCity.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CountryStateCityDbContext>(options =>

                options.UseSqlServer(configuration.GetConnectionString("BlogdbContext") ??
                    throw new Exception("connection string 'BlogdbContext not found' "))
            );

            services.AddTransient<IRepository, BaseRepository>();
            services.AddTransient<ICityQueries, CityQueries>();
            services.AddTransient<ICountryQueries, CountryQueries>();
            services.AddTransient<IStateQueries, StateQueries>();

            return services;
        }
    }
}
