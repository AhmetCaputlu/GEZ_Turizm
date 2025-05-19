using DataAccess.Context;
using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Repositories.Abstracts.Vehicle;
using DataAccess.Repositories.Abstracts.VehicleR;
using DataAccess.Repositories.Concretes.Vehicle;

namespace DataAccess.Repositories.Concretes.VehicleR
{
    public class RentalVehicleRepository : GenericVehicleRepository<RentalVehicle, RentalVehicleFilterModel>, IRentalVehicleRepository
    {
        private readonly GezTurizmContext _context;
        public RentalVehicleRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<RentalVehicle> GetDynamicFilteredEntities(RentalVehicleFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.Descending != true && filterModel.DescendingByRentalDay.HasValue)
            {
                filter = filter.OrderByDescending(x => x.TotalRentalDay);
            }
            else if (filterModel.Descending != true && filterModel.DescendingFee.HasValue)
            {
                filter = filter.OrderByDescending(x => x.DailyRentalFee);
            }

            return filter;
        }
    }
}
