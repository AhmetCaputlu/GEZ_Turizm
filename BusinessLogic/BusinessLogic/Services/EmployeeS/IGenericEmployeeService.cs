using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.Services.EmployeeS
{
    public interface IGenericEmployeeService<TEntity, TResponse, TRequest, TFilterEntity> :
        IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : BaseEmployeeModel where TResponse : BaseEmployeeResponseDTO
        where TRequest : BaseEmployeeRequestDTO where TFilterEntity : BaseEmployeeFilterModel, new()
    {

    }
}
