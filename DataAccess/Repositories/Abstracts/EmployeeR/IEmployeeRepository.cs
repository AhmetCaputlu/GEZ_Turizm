using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Repositories.Abstracts.Employee;

namespace DataAccess.Repositories.Abstracts.EmployeeR
{
    public interface IEmployeeRepository : IGenericEmployeeRepository<Entities.Models.Employees.Employee, EmployeeFilterModel>
    {

    }
}
