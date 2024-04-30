using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.city.Queries.GetCities
{
    public class GetCitiesQuery : IRequest<List<CityVM>>
    {
    }
}
