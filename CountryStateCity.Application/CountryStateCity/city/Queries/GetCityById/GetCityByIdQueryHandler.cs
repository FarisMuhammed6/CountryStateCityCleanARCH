using AutoMapper;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Application.CountryStateCity.state;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Queries.GetCityById
{
    public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, CityVM>
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public GetCityByIdQueryHandler(ICityRepository cityRepository,IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }
        public async Task<CityVM> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            var City = await cityRepository.GetByIdAsync(request.CityId);

            var citylist = mapper.Map<CityVM>(City);

            return citylist;
        }
    }
}
