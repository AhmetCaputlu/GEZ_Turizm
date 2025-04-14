using DataAccess.Repositories.Abstracts.Vehicle;

namespace DataAccess.Repositories.Abstracts.VehicleR
{
    public interface IVehicleRepository:IGenericVehicleRepository<DataAccess.Entities.Models.Vehicles.Vehicle>
    {
        IQueryable<DataAccess.Entities.Models.Vehicles.Vehicle> GetVehiclesByPurchaseDate(DateTime dateTime);
        IQueryable<DataAccess.Entities.Models.Vehicles.Vehicle> GetVehiclesByPriceDesc();
    }
}
