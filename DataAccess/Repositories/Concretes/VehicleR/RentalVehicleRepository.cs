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

        public IQueryable<RentalVehicle> GetRentalVehiclesByDailyRentalFeeDesc()
        {
            return _context.RentalVehicles.OrderByDescending(x => x.DailyRentalFee);
        }

        public IQueryable<RentalVehicle> GetRentalVehiclesByTotalRentDayDesc()
        {
            return _context.RentalVehicles.OrderByDescending(x => x.TotalRentalDay);
        }
    }
}
