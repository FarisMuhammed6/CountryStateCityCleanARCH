using CountryStateCity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Domain.Interface
{
    public interface ICountryRepository
    {
          Task<List<Country>> GetAllAsync();
          Task<Country> GetByIdAsync(int id);
          Task<Country> CreateAsync(Country country);
          Task<int> UpdateAsync(int Id, Country country);
          Task<int> DeleteByIdAsync(int id);
        
    }
}
