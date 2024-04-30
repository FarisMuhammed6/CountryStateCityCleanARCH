using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Commands.UpdateCountry
{
    public class UpdateCountryCommand  :IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
