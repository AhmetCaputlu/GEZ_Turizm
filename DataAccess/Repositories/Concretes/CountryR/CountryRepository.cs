using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Countries;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.Countryy;

namespace DataAccess.Repositories.Concretes.Countryy
{
    public class CountryRepository : GenericRepository<Country>, IGenericRepository<Country>, ICountryRepository
    {
        private readonly GezTurizmContext _context;

        public CountryRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Country> GetCountriesByContinent(Continent continent)
        {
            return _context.Countries.Where(x => x.Continent == continent);
        }
    }
}
