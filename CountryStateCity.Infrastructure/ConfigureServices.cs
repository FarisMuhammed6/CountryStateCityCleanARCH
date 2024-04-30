using CountryStateCity.Domain.Interface;
using CountryStateCity.Infrastructure.Data;
using CountryStateCity.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            services.AddTransient<ICountryRepository,CountryRepository>();
            services.AddTransient<IStateRepository,StateRepository>();
            services.AddTransient<ICityRepository,CityRepository>();    
            return services;
        }
    }
}
