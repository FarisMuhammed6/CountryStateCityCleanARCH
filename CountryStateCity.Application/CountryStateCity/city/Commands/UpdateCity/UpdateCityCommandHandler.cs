using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Commands.UpdateCity
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, int>
    {
        private readonly ICityRepository cityRepository;

        public UpdateCityCommandHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<int> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            var updateentity = new City
            {
                Name = request.Name,
                StateId = request.StateId
            };
            return await cityRepository.UpdateAsync(request.Id, updateentity);
        }
    }
}
