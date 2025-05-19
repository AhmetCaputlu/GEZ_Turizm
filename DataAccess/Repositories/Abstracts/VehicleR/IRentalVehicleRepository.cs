using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.Repositories.Abstracts.Vehicle;

namespace DataAccess.Repositories.Abstracts.VehicleR
{
    public interface IRentalVehicleRepository : IGenericVehicleRepository<RentalVehicle, RentalVehicleFilterModel>
    {
     
    }
}
