using DataAccess.Context;
using DataAccess.Entities.FilterModels.Vehicles;

namespace DataAccess.Repositories.VehicleR
{
    public class VehicleRepository : GenericVehicleRepository<Entities.Models.Vehicles.Vehicle,VehicleFilterModel>, IVehicleRepository
    {
        private readonly GezTurizmContext _context;

        public VehicleRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }


        public override IQueryable<Entities.Models.Vehicles.Vehicle> GetDynamicFilteredEntities(VehicleFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.PurchaseDate.HasValue)
            {
                filter = filter.Where(x => x.PurchaseDate.Date == filterModel.PurchaseDate.Value.Date);
            }
            if (filterModel.Descending != true && filterModel.DescendingByMarketValue == true)
            {
                filter = filter.OrderByDescending(x => x.MarketValue);
            }

            return filter;
        }
    }
}
