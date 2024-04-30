using AutoMapper;
using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Commands.CreateCity
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CityVM>
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public CreateCityCommandHandler(ICityRepository cityRepository,IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }
        public async Task<CityVM> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var cityentity = new City
            {
                Name = request.Name,
                StateId = request.StateId
            };
            var result = await cityRepository.CreateAsync(cityentity);
            return mapper.Map<CityVM>(result);
        }
    }
}
