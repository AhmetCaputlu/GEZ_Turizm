using BusinessLogic.DTOs.Vehicles;
using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Entities.Models.Vehicles;

namespace BusinessLogic.Services.VehicleS
{
    public interface IRentalVehicleService : IGenericVehicleService<RentalVehicle, RentalVehicleResponseDTO, RentalVehicleRequestDTO, RentalVehicleFilterModel>
    {

    }
}
