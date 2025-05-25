using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.FilterModels.Vehicles;

namespace BusinessLogic.Services.VehicleS
{
    public interface IGenericVehicleService<TEntity, TResponse, TRequest, TFilterEntity> :
        IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : BaseVehicleModel where TResponse : BaseVehicleResponseDTO
        where TRequest : BaseVehicleRequestDTO where TFilterEntity : BaseVehicleFilterModel, new()
    {

    }
}
