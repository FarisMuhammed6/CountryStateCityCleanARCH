using AutoMapper;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Queries.GetCountries
{
    public class GetCountriesQueryHandler : IRequestHandler<GetCountriesQuery, List<CountryVM>>
    {
        private readonly ICountryRepository countryRepository;
        private readonly IMapper mapper;

        public GetCountriesQueryHandler(ICountryRepository countryRepository,IMapper mapper)
        {
            this.countryRepository = countryRepository;
            this.mapper = mapper;
        }
        public async Task<List<CountryVM>> Handle(GetCountriesQuery request, CancellationToken cancellationToken)
        {
            var Countries = await countryRepository.GetAllAsync();
            var CountryList = mapper.Map<List<CountryVM>>(Countries);
            return CountryList;
        }
    }
}
