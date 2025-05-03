using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts.Vehicle
{
    public interface IGenericVehicleRepository<T> : IGenericRepository<T> where T : BaseVehicleModel
    {
        IQueryable<T> GetDynamicVehicleFilter(
            VehicleType? vehicleType = null,
            string? licensePlate = null,
            string? model = null,
            bool? available = null,
            bool? descending = null
            );
    }
}
