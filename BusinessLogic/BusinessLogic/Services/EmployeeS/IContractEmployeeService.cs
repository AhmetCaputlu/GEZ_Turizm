using BusinessLogic.DTOs.Employees;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Models.Employees;

namespace BusinessLogic.Services.EmployeeS
{
    public interface IContractEmployeeService : IGenericEmployeeService<ContractEmployee, ContractEmployeeResponseDTO, ContractEmployeeRequestDTO, ContractEmployeeFilterModel>
    {
    }
}
