using AutoMapper;
using CountryStateCity.Application.CountryStateCity.city;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Domain.DTOS.AllList;
using CountryStateCity.Domain.Interface.Queries.Maters;
using CountryStateCity.Infrastructure.Data;

namespace CountryStateCity.Infrastructure.Queries
{
    public class CityQueries : ICityQueries
    {
        private readonly CountryStateCityDbContext dbContext;
        private readonly IMapper mapper;

        public CityQueries(CountryStateCityDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }



        public IList<CityDTO> GetAllCities()
        {
            return mapper.Map<IList<CityDTO>>(dbContext.cities.ToList());

        }

        public CityDTO GetCityById(int Id)
        {
            return mapper.Map<CityDTO>(dbContext.cities.FirstOrDefault(c => c.Id == Id));
        }
        public IList<CityDTO2> GetAll()
        {
            var cities = (from c in dbContext.cities.ToList()
                         join s in dbContext.states.ToList() on c.StateId equals s.Id
                         join coun in dbContext.countries.ToList() on s.CountryId equals coun.Id
                         select new CityDTO2
                         {
                             Id = c.Id,
                             Name = c.Name,
                             StateId = c.StateId,
                             states = new StateDTO2
                             {
                                 Id = s.Id,
                                 Name = s.Name,
                                 CountryId = s.CountryId,
                                 countries = mapper.Map<CountryDTO>(s.Country)
                                /* {
                                     Id = coun.Id,
                                     Name = coun.Name

                                 }*/

                             }
                         }).ToList();
            //return mapper.Map<IList<CityDTO2>>(cities);
            return cities;



 /* dbContext.cities.Include(city => city.State).ThenInclude(state => state.Country)
            .ToList();*/



        }
    }
}
