using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Commands.CreateState
{
    public class CreateStateCommand : IRequest<StateVM>
    {
        public string? Name { get; set; }
        public int CountryId { get; set; }
    }
}
