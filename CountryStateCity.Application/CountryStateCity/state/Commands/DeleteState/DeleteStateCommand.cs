using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.state.Commands.DeleteState
{
    public class DeleteStateCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
