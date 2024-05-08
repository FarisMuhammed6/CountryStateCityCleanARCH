using CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry;
using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;

namespace CountryStateCity.Application.CountryStateCity.country.Commands
{
    public class UpdateCountryCommandHamdler : IRequestHandler<UpdateCountryCommand, int>
    {

        private readonly IRepository repository;

        public UpdateCountryCommandHamdler(IRepository repository)
        {

            this.repository = repository;
        }
        public async Task<int> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
        {
            var updateentity = new Country
            {
                Name = request.Name
            };
            return await repository.UpdateCountryAsync(request.Id, updateentity);
        }
    }
}
