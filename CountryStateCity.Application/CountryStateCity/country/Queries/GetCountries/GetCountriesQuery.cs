using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Queries.GetCountries
{
    public class GetCountriesQuery : IRequest<List<CountryVM>>
    {

    }
}
