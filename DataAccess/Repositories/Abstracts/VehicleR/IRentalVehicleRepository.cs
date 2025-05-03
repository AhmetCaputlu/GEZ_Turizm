using DataAccess.Entities.Models.Vehicles;
using DataAccess.Repositories.Abstracts.Vehicle;

namespace DataAccess.Repositories.Abstracts.VehicleR
{
    public interface IRentalVehicleRepository : IGenericVehicleRepository<RentalVehicle>
    {
        IQueryable<RentalVehicle> GetDynamicRentalVehicleFilter(bool? descendingDay = null, bool? descendingFee = null, bool? descending = null);
    }
}
