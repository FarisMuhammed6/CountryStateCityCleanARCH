using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Queries.GetCityById
{
    public class GetCityByIdQuery : IRequest<CityVM>
    {
        public int CityId { get; set; }
    }
}
