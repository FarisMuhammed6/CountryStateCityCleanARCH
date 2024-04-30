using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Commands.DeleteCity
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, int>
    {
        private readonly ICityRepository cityRepository;

        public DeleteCityCommandHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<int> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            return await cityRepository.DeleteByIdAsync(request.Id);
        }
    }
}
