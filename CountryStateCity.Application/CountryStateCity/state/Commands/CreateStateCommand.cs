using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Commands
{
    public class CreateStateCommand : IRequest<StateDTO>
    {
        public string? Name { get; set; }
        public int CountryId { get; set; }
    }
}
