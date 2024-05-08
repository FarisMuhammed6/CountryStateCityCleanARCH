using CountryStateCity.Application.CountryStateCity.country;
using CountryStateCity.Application.CountryStateCity.state;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Domain.DTOS.AllList
{
    public class CityDTO2
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StateId { get; set; }
        public StateDTO2? states { get; set; }
     
    }
}
