using AutoMapper;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;

namespace CountryStateCity.Application.CountryStateCity.country.Commands
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, CountryDTO>
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CreateCountryCommandHandler(IRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<CountryDTO> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var countryentity = new Country
            {
                Name = request.Name
            };
            var result = await repository.CreateCountryAsync(countryentity);
            return mapper.Map<CountryDTO>(result);
        }
    }
}
