using CountryStateCity.Domain.Entities;
using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry
{
    public class UpdateCountryCommandHamdler : IRequestHandler<UpdateCountryCommand, int>
    {
        private readonly ICountryRepository countryRepository;

        public UpdateCountryCommandHamdler(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        public async Task<int> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
        {
            var updateentity = new Country
            {
                Name = request.Name
            };
            return await countryRepository.UpdateAsync(request.Id, updateentity);
        }
    }
}
