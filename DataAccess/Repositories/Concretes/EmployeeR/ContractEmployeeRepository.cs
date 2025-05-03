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
        public IQueryable<ContractEmployee> GetDynamicContractEmployeeFilter(DriverLicense? driverLicense = null, Language? language = null, bool? descending = null)
        {
            IQueryable<ContractEmployee> filter = _context.ContractEmployees;
            if (driverLicense.HasValue)
            {
                filter = filter.Where(x => (x.DriverLicense ?? DriverLicense.None) == driverLicense.Value);
            }
            if (language.HasValue)
            {
                filter = filter.Where(x => (x.Language ?? Language.None) == language.Value);
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
