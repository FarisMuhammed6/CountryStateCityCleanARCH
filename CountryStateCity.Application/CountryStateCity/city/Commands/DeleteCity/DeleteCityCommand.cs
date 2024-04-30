using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Commands.DeleteCity
{
    public class DeleteCityCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
