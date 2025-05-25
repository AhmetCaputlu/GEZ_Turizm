using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Models.Employees;

namespace DataAccess.Repositories.EmployeeR
{
    public interface IContractEmployeeRepository : IGenericEmployeeRepository<ContractEmployee,ContractEmployeeFilterModel>
    {
        
    }
}
