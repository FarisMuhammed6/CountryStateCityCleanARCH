using CountryStateCity.Application.CountryStateCity.country;

namespace CountryStateCity.Application.CountryStateCity.state
{
    public class StateDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CountryId { get; set; }
        
    }
}
