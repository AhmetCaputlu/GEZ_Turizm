using DataAccess.Context;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Repositories.Abstracts.Vehicle;
using DataAccess.Repositories.Abstracts.VehicleR;
using DataAccess.Repositories.Concretes.Vehicle;

namespace DataAccess.Repositories.Concretes.VehicleR
{
    public class RentalVehicleRepository : GenericVehicleRepository<RentalVehicle>, IGenericVehicleRepository<RentalVehicle>, IRentalVehicleRepository
    {
        private readonly GezTurizmContext _context;
        public RentalVehicleRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<RentalVehicle> GetDynamicRentalVehicleFilter(bool? descendingDay = null, bool? descendingFee = null, bool? descending = null)
        {
            IQueryable<RentalVehicle> filter = _context.RentalVehicles;
            if (descendingDay.HasValue)
            {
                filter = filter.OrderByDescending(x => x.TotalRentalDay);
            }
            else if (descendingFee.HasValue)
            {
                filter = filter.OrderByDescending(x => x.DailyRentalFee);
            }
            else if (descending.HasValue)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
