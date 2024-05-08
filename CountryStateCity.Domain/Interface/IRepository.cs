using CountryStateCity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Domain.Interface
{
    public interface IRepository
    {

        Task<City> CreateCityAsync(City city);
        Task<int> UpdateCityAsync(int Id, City city);
        Task<int> DeleteCityByIdAsync(int id);

        Task<Country> CreateCountryAsync(Country country);
        Task<int> UpdateCountryAsync(int Id, Country country);
        Task<int> DeleteCountryByIdAsync(int id);

        Task<State> CreateStateAsync(State state);
        Task<int> UpdateStateAsync(int Id, State state);
        Task<int> DeleteStateByIdAsync(int id);
    }
}
