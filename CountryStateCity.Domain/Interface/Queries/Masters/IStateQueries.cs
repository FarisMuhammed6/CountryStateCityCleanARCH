using CountryStateCity.Application.CountryStateCity.state;

namespace CountryStateCity.Domain.Interface.Queries.Maters
{
    public interface IStateQueries
    {
        IList<StateDTO> GetAll();
        StateDTO GetStateById(int Id);
    }
}
