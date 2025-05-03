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

        public IQueryable<Country> GetDynamicCountryFilter(Continent? continent = null, bool? descending = null)
        {
            IQueryable<Country> filter = _context.Countries;
            if (continent.HasValue)
            {
                filter = filter.Where(x => x.Continent == continent.Value);
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
