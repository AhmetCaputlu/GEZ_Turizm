using BusinessLogic.DTOs.Vehicles;
using DataAccess.Entities.FilterModels.Vehicles;

namespace BusinessLogic.Services.VehicleS
{
    public interface IVehicleService : IGenericVehicleService<DataAccess.Entities.Models.Vehicles.Vehicle, VehicleResponseDTO, VehicleRequestDTO, VehicleFilterModel>
    {

    }
}
