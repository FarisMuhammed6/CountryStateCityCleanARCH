using AutoMapper;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Commands.CreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand , CountryVM>
    {
        private readonly ICountryRepository countryRepository;
        private readonly IMapper mapper;

        public CreateCountryCommandHandler(ICountryRepository countryRepository,IMapper mapper)
        {
            this.countryRepository = countryRepository;
            this.mapper = mapper;
        }

        public async Task<CountryVM> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var countryentity = new Country
            {
                Name = request.Name
            };
            var result = await countryRepository.CreateAsync(countryentity);
            return mapper.Map<CountryVM>(result);
        }
    }
}
