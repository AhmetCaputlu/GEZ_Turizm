using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Repositories.Abstracts.Vehicle;

namespace DataAccess.Repositories.Abstracts.VehicleR
{
    public interface IVehicleRepository : IGenericVehicleRepository<Entities.Models.Vehicles.Vehicle, VehicleFilterModel>
    {

    }
}
