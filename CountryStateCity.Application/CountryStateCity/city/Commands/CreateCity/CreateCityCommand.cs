using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Commands.CreateCity
{
    public class CreateCityCommand : IRequest<CityVM>
    {
        public string? Name { get; set; }
        public int StateId { get; set; }
    }
}
