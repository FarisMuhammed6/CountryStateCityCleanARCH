using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using CountryStateCity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Infrastructure.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly CountryStateCityDbContext dbContext;

        public CityRepository(CountryStateCityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<City> CreateAsync(City city)
        {
            await dbContext.AddAsync(city);
            await dbContext.SaveChangesAsync();
            return city;
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            return await dbContext.cities.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await dbContext.cities.ToListAsync();
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await dbContext.cities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(int Id, City city)
        {
            return await dbContext.cities.Where(x => x.Id == Id)
                                        .ExecuteUpdateAsync(setters => setters

                                                           .SetProperty(m => m.Name, city.Name)
                                                           .SetProperty(m => m.StateId, city.StateId)
                                                           );
        }
    }
}
