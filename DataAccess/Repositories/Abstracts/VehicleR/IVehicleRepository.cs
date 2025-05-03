using DataAccess.Repositories.Abstracts.Vehicle;

namespace DataAccess.Repositories.Abstracts.VehicleR
{
    public interface IVehicleRepository:IGenericVehicleRepository<DataAccess.Entities.Models.Vehicles.Vehicle>
    {
        IQueryable<DataAccess.Entities.Models.Vehicles.Vehicle> GetDynamicVehiclesFilter(DateTime? dateTime = null, bool? descendingPrice = null, bool? descending = null);
    }
}
