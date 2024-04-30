using AutoMapper;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Queries.GetCities
{
    public class GetCitiesQueryHandler : IRequestHandler<GetCitiesQuery, List<CityVM>>
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public GetCitiesQueryHandler(ICityRepository cityRepository,IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }
        public async Task<List<CityVM>> Handle(GetCitiesQuery request, CancellationToken cancellationToken)
        {
            var Cities = await cityRepository.GetAllAsync();
            var CityList = mapper.Map<List<CityVM>>(Cities);
            return CityList;
        }
    }
}
