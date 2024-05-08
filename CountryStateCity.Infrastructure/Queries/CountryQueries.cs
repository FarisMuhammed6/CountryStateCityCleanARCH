using AutoMapper;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Domain.Interface.Queries.Maters;
using CountryStateCity.Infrastructure.Data;

namespace CountryStateCity.Infrastructure.Queries
{
    public class CountryQueries : ICountryQueries
    {
        private readonly CountryStateCityDbContext dbContext;
        private readonly IMapper mapper;

        public CountryQueries(CountryStateCityDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public IList<CountryDTO> GetAll()
        {
            return mapper.Map<IList<CountryDTO>>(dbContext.countries.ToList());
        }

        public CountryDTO GetCountryById(int Id)
        {
            return mapper.Map<CountryDTO>(dbContext.countries.FirstOrDefault(c => c.Id == Id));
        }
    }
}
