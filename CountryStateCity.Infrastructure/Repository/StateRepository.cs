using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using CountryStateCity.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Infrastructure.Repository
{
    public class StateRepository : IStateRepository
    {
        private readonly CountryStateCityDbContext dbContext;

        public StateRepository(CountryStateCityDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<State> CreateAsync(State state)
        {
            await dbContext.AddAsync(state);
            await dbContext.SaveChangesAsync();
            return state;
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            return await dbContext.states.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<State>> GetAllAsync()
        {
            return await dbContext.states.ToListAsync();
        }

        public async Task<State> GetByIdAsync(int id)
        {
            return await dbContext.states.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateAsync(int Id, State state)
        {
            return await dbContext.states.Where(x => x.Id == Id)
                                         .ExecuteUpdateAsync(setters => setters

                                                            .SetProperty(m => m.Name, state.Name)
                                                            .SetProperty(m => m.CountryId, state.CountryId)
                                                            ); 
        }
    }
}
