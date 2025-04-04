using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts
{
    public interface IVehicleRepository<T> : IRepository<T> where T : BaseVehicleModel
    {
        IQueryable<T> GetVehicleByVehicleType(VehicleType vehicleType);
        IQueryable<T> GetVehicleByLicensePlate(string licensePlate);
        IQueryable<T> GetVehicleByModel(string model);
        IQueryable<T> GetVehicleByKilometerDesc();
        IQueryable<T> GetVehicleByAgeDesc();
        IQueryable<T> GetVehicleByCapacityDesc();
    }
}
