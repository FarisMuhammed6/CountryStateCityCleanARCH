using CountryStateCity.Application.CountryStateCity.country.Commands.DeleteCountry;
using CountryStateCity.Domain.Interface;
using MediatR;

namespace CountryStateCity.Application.CountryStateCity.country.Commands
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, int>
    {
        private readonly IRepository repository;

        public DeleteCountryCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<int> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            return await repository.DeleteCountryByIdAsync(request.Id);
        }
    }
}
