using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts.Employee;

namespace DataAccess.Repositories.Abstracts.EmployeeR
{
    public interface IEmployeeRepository:IGenericEmployeeRepository<DataAccess.Entities.Models.Employees.Employee>
    {                                                                   //Ne yazık ki using etiketini tanımıyor.
        IQueryable<DataAccess.Entities.Models.Employees.Employee> GetDynamicEmployeesFilter(Department? department = null, bool? descending = null);
    }
}
