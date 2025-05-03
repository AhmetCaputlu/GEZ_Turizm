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

        public IQueryable<Entities.Models.Vehicles.Vehicle> GetDynamicVehiclesFilter(DateTime? dateTime = null, bool? descendingPrice = null, bool? descending = null)
        {
            IQueryable<Entities.Models.Vehicles.Vehicle> filter = _context.Vehicles;
            if (dateTime.HasValue)
            {
                filter = filter.Where(x => x.PurchaseDate.Date == dateTime.Value.Date);
            }
            if (descendingPrice == true)
            {
                filter = filter.OrderByDescending(x => x.MarketValue);
            }
            else if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
