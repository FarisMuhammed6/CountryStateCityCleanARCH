using CountryStateCity.Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Commands.DeleteCountry
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, int>
    {
        private readonly ICountryRepository countryRepository;

        public DeleteCountryCommandHandler(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        public async Task<int> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            return await countryRepository.DeleteByIdAsync(request.Id);
        }
    }
}
