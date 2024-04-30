using CountryStateCity.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Commands.CreateCountry
{
    public class CreateCountryCommand : IRequest<CountryVM>
    {
        public string? Name { get; set; }
    }
}
