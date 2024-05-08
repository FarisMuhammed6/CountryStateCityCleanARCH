using MediatR;

namespace CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry
{
    public class UpdateCountryCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
