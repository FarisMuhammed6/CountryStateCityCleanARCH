using CountryStateCity.Application.CountryStateCity.country;

namespace CountryStateCity.Domain.Interface.Queries.Maters
{
    public interface ICountryQueries
    {
        IList<CountryDTO> GetAll();
        CountryDTO GetCountryById(int Id);
    }
}
