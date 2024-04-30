using CountryStateCity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Domain.Interface
{
    public interface IStateRepository
    {
        Task<List<State>> GetAllAsync();
        Task<State> GetByIdAsync(int id);
        Task<State> CreateAsync(State state);
        Task<int> UpdateAsync(int Id, State state);
        Task<int> DeleteByIdAsync(int id);
    }
}
