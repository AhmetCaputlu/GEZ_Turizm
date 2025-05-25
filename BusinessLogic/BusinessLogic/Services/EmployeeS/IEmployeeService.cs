using BusinessLogic.DTOs.Employees;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Models.Employees;

namespace BusinessLogic.Services.EmployeeS
{
    public interface IEmployeeService : IGenericEmployeeService<Employee, EmployeeResponseDTO, EmployeeRequestDTO, EmployeeFilterModel>
    {

    }
}
