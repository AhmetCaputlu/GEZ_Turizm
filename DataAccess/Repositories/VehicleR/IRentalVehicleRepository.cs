using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Repositories.VehicleR
{
    public interface IRentalVehicleRepository : IGenericVehicleRepository<RentalVehicle, RentalVehicleFilterModel>
    {
     
    }
}
