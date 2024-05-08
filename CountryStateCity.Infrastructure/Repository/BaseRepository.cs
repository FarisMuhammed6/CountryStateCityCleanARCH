using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using CountryStateCity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CountryStateCity.Infrastructure.Repository
{
    public class BaseRepository : IRepository
    {
        private readonly CountryStateCityDbContext dbContext;

        public BaseRepository(CountryStateCityDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<City> CreateCityAsync(City city)
        {
            await dbContext.AddAsync(city);
            await dbContext.SaveChangesAsync();
            return city;
        }

        public async Task<int> DeleteCityByIdAsync(int id)
        {
            return await dbContext.cities.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<int> UpdateCityAsync(int Id, City city)
        {
            return await dbContext.cities.Where(x => x.Id == Id)
                                        .ExecuteUpdateAsync(setters => setters

                                                           .SetProperty(m => m.Name, city.Name)
                                                           .SetProperty(m => m.StateId, city.StateId)
                                                           );
        }
        public async Task<State> CreateStateAsync(State state)
        {
            await dbContext.AddAsync(state);
            await dbContext.SaveChangesAsync();
            return state;
        }

        public async Task<int> DeleteStateByIdAsync(int id)
        {
            return await dbContext.states.Where(x => x.Id == id).ExecuteDeleteAsync();
        }
        public async Task<int> UpdateStateAsync(int Id, State state)
        {
            return await dbContext.states.Where(x => x.Id == Id)
                                         .ExecuteUpdateAsync(setters => setters

                                                            .SetProperty(m => m.Name, state.Name)
                                                            .SetProperty(m => m.CountryId, state.CountryId)
                                                            );
        }
        public async Task<Country> CreateCountryAsync(Country country)
        {
            await dbContext.AddAsync(country);
            await dbContext.SaveChangesAsync();
            return country;
        }

        public async Task<int> DeleteCountryByIdAsync(int id)
        {
            return await dbContext.countries.Where(x => x.Id == id).ExecuteDeleteAsync();
        }
        public async Task<int> UpdateCountryAsync(int Id, Country country)
        {
            return await dbContext.countries.Where(x => x.Id == Id)
                                        .ExecuteUpdateAsync(setters => setters

                                                           .SetProperty(m => m.Name, country.Name)
                                                           );
        }
    }
}
