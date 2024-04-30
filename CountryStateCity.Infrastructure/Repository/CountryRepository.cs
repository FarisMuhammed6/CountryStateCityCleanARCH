using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using CountryStateCity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Infrastructure.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly CountryStateCityDbContext dbContext;

        public CountryRepository(CountryStateCityDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public async Task<Country> CreateAsync(Country country)
        {
            await dbContext.AddAsync(country);
            await dbContext.SaveChangesAsync();
            return country;
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            return await dbContext.countries.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Country>> GetAllAsync()
        {
            return await dbContext.countries.ToListAsync();
        }

        public async Task<Country> GetByIdAsync(int id)
        {
            return await dbContext.countries.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(int Id, Country country)
        {
            return await dbContext.countries.Where(x => x.Id == Id)
                                        .ExecuteUpdateAsync(setters => setters

                                                           .SetProperty(m => m.Name, country.Name)
                                                           );
        }


    }
}
