using CountryStateCity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Domain.Interface
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllAsync();
        Task<City> GetByIdAsync(int id);
        Task<City> CreateAsync(City city);
        Task<int> UpdateAsync(int Id, City city);
        Task<int> DeleteByIdAsync(int id);
    }
}
