using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Countries;

namespace DataAccess.Repositories.Abstracts.Countryy//Sınıf adı ile çakışma yaşadığı için sonunu ikiledim
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        IQueryable<Country> GetCountriesByContinent(Continent continent);
    }
}
