using DataAccess.Entities.Models.Vehicles;
using DataAccess.Repositories.Abstracts.Vehicle;

namespace DataAccess.Repositories.Abstracts.VehicleR
{
    public interface IRentalVehicleRepository:IGenericVehicleRepository<RentalVehicle>
    {
        IQueryable<RentalVehicle> GetRentalVehiclesByTotalRentDayDesc();
        IQueryable<RentalVehicle> GetRentalVehiclesByDailyRentalFeeDesc();
    }
}
