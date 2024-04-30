using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country.Queries.GetCountryById
{
    public class GetCountryByIdQuery : IRequest<CountryVM>
    {
        public int CountryId { get; set; }  
    }
}
