using DataAccess.Entities.FilterModels.Vehicles;

namespace DataAccess.Repositories.VehicleR
{
    public interface IVehicleRepository : IGenericVehicleRepository<Entities.Models.Vehicles.Vehicle, VehicleFilterModel>
    {

    }
}
