using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Repositories.RegionR
{
    public class CountryRepository : GenericRepository<Country, CountryFilterModel>, ICountryRepository
    {
        private readonly GezTurizmContext _context;

        public CountryRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public override IQueryable<Country> GetDynamicFilteredEntities(CountryFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.Continent.HasValue)
            {
                filter = filter.Where(x => x.Continent == filterModel.Continent.Value);
            }
            if (filterModel.Descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
