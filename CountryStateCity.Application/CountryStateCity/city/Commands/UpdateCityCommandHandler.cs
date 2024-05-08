using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Commands
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, int>
    {
        private readonly IRepository repository;

        public UpdateCityCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<int> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            var updateentity = new City
            {
                Name = request.Name,
                StateId = request.StateId
            };
            return await repository.UpdateCityAsync(request.Id, updateentity);
        }
    }
}
