using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts.Employee;

namespace DataAccess.Repositories.Abstracts.EmployeeR
{
    public interface IContractDriverRepository:IGenericEmployeeRepository<ContractDriver>
    {
        IQueryable<ContractDriver> GetDriversByLicense(DriverLicense driverLicense);
    }
}
