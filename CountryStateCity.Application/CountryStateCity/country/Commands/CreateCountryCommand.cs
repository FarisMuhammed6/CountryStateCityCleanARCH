
using MediatR;

namespace CountryStateCity.Application.CountryStateCity.country.Commands
{
    public class CreateCountryCommand : IRequest<CountryDTO>
    {
        public string? Name { get; set; }
    }
}
