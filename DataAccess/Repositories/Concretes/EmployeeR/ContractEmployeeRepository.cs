using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.Employee;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Concretes.Employee;

namespace DataAccess.Repositories.Concretes.EmployeeR
{
    public class ContractEmployeeRepository : GenericEmployeeRepository<ContractEmployee>, IContractEmployeeRepository
    {
        private readonly GezTurizmContext _context;

        public ContractEmployeeRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<ContractEmployee> GetDriversByLicense(DriverLicense driverLicense)
        {
            return _context.ContractEmployees.Where(x => x.DriverLicense == driverLicense);
        }

        public IQueryable<ContractEmployee> GetTourGuidesByLanguage(Language language)
        {
            return _context.ContractEmployees.Where(x => x.Language == language);
        }
    }
}
