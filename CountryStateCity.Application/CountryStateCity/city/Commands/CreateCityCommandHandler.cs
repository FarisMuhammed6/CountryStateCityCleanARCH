using AutoMapper;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;

namespace CountryStateCity.Application.CountryStateCity.city.Commands
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CityDTO>
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CreateCityCommandHandler(IRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task<CityDTO> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var cityentity = new City
            {
                Name = request.Name,
                StateId = request.StateId
            };          
            var result = await repository.CreateCityAsync(cityentity);
            return mapper.Map<CityDTO>(result);
        }
    }
}
