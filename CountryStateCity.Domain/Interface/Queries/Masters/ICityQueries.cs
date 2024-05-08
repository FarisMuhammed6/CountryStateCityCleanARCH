using CountryStateCity.Application.CountryStateCity.city;
using CountryStateCity.Domain.DTOS.AllList;

namespace CountryStateCity.Domain.Interface.Queries.Maters
{
    public interface ICityQueries
    {
        IList<CityDTO> GetAllCities();
        CityDTO GetCityById(int Id);
        IList<CityDTO2> GetAll();


    }
}
