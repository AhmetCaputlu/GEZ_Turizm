using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Vehicles;

namespace DataAccess.Repositories.Abstracts.Vehicle
{
    public interface IGenericVehicleRepository<TEntity, TFilterEntity> : IGenericRepository<TEntity, TFilterEntity> where TEntity : BaseVehicleModel where TFilterEntity : BaseVehicleFilterModel
    {

    }
}
