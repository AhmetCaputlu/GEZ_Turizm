using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts.Employee;

namespace DataAccess.Repositories.Abstracts.EmployeeR
{
    public interface IContractEmployeeRepository : IGenericEmployeeRepository<ContractEmployee,ContractEmployeeFilterModel>
    {
        
    }
}
