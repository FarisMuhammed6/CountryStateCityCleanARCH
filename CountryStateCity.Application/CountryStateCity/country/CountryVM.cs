using CountryStateCity.Application.Common.Mappings;
using CountryStateCity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Application.CountryStateCity.country
{
    public class CountryVM : IMapFrom<Country>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
