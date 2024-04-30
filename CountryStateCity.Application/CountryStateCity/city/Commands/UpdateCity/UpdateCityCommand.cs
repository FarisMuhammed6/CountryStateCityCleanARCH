using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Commands.UpdateCity
{
    public class UpdateCityCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StateId { get; set; }
    }
}
