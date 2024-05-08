using CountryStateCity.Application.CountryStateCity.country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryStateCity.Domain.DTOS.AllList
{
    public class StateDTO2
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CountryId { get; set; }
        public CountryDTO? countries { get; set; }
    }
}
