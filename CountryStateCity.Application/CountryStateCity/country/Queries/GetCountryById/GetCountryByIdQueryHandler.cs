using AutoMapper;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Queries.GetCountryById
{
    public class GetCountryByIdQueryHandler : IRequestHandler<GetCountryByIdQuery, CountryVM>
    {
        private readonly ICountryRepository countryRepository;
        private readonly IMapper mapper;

        public GetCountryByIdQueryHandler(ICountryRepository countryRepository,IMapper mapper)
        {
            this.countryRepository = countryRepository;
            this.mapper = mapper;
        }
        public async Task<CountryVM> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
        {

            var Country = await countryRepository.GetByIdAsync(request.CountryId);

            var CountryList = mapper.Map<CountryVM>(Country);

            return CountryList;
        }
    }
}
