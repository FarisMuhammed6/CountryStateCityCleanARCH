using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Queries.GetStates
{
    public class GetStatesQuery : IRequest<List<StateVM>>
    {
        public int StateId { get; set; }
    }
}
