using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts.Employee;

namespace DataAccess.Repositories.Abstracts.EmployeeR
{
    public interface IContractEmployeeRepository : IGenericEmployeeRepository<ContractEmployee>
    {
        IQueryable<ContractEmployee> GetDriversByLicense(DriverLicense driverLicense);
        IQueryable<ContractEmployee> GetTourGuidesByLanguage(Language language);
    }
}
