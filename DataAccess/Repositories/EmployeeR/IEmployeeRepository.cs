using DataAccess.Entities.FilterModels.Employees;

namespace DataAccess.Repositories.EmployeeR
{
    public interface IEmployeeRepository : IGenericEmployeeRepository<Entities.Models.Employees.Employee, EmployeeFilterModel>
    {

    }
}
