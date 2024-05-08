using CountryStateCity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Infrastructure.Data
{
    public class CountryStateCityDbContext : DbContext
    {
        public CountryStateCityDbContext(DbContextOptions<CountryStateCityDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Country> countries { get; set; }
        public DbSet<State> states { get; set; }
        public DbSet<City> cities { get; set; }
        
    }
}
