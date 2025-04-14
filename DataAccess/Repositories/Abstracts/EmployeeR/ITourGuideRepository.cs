using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts.Employee;

namespace DataAccess.Repositories.Abstracts.EmployeeR
{
    public interface ITourGuideRepository:IGenericEmployeeRepository<ContractTourGuide>
    {
        IQueryable<ContractTourGuide> GetTourGuidesByLanguage(Language language);
    }
}
