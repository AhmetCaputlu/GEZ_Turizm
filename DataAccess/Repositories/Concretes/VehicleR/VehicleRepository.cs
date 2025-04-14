using DataAccess.Context;
using DataAccess.Repositories.Abstracts.Vehicle;
using DataAccess.Repositories.Abstracts.VehicleR;
using DataAccess.Repositories.Concretes.Vehicle;

namespace DataAccess.Repositories.Concretes.VehicleR
{
    public class VehicleRepository : GenericVehicleRepository<Entities.Models.Vehicles.Vehicle>, IGenericVehicleRepository<Entities.Models.Vehicles.Vehicle>, IVehicleRepository
    {
        private readonly GezTurizmContext _context;

        public VehicleRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Entities.Models.Vehicles.Vehicle> GetVehiclesByPriceDesc()
        {
            return _context.Vehicles.OrderByDescending(x => x.MarketValue);
        }

        public IQueryable<Entities.Models.Vehicles.Vehicle> GetVehiclesByPurchaseDate(DateTime dateTime)
        {
            return _context.Vehicles.Where(x => x.PurchaseDate.Date == dateTime.Date);
        }
    }
}
