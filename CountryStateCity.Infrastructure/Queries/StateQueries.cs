using AutoMapper;
using CountryStateCity.Application.CountryStateCity.state;
using CountryStateCity.Domain.Interface.Queries.Maters;
using CountryStateCity.Infrastructure.Data;

namespace CountryStateCity.Infrastructure.Queries
{
    public class StateQueries : IStateQueries
    {
        private readonly CountryStateCityDbContext dbContext;
        private readonly IMapper mapper;

        public StateQueries(CountryStateCityDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public IList<StateDTO> GetAll()
        {
            return mapper.Map<IList<StateDTO>>(dbContext.states.ToList());
        }

        public StateDTO GetStateById(int Id)
        {
            return mapper.Map<StateDTO>(dbContext.states.FirstOrDefault(s => s.Id == Id));
        }
    }
}
