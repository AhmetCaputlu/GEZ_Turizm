using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts.Employee;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Concretes.Employee;

namespace DataAccess.Repositories.Concretes.EmployeeR
{
    public class ContractDriverRepository : GenericEmployeeRepository<ContractDriver>, IGenericEmployeeRepository<ContractDriver>, IContractDriverRepository
    {
        private readonly GezTurizmContext _context;

        public ContractDriverRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<ContractDriver> GetDriversByLicense(DriverLicense driverLicense)
        {
            return _context.ContractDrivers.Where(x => x.DriverLicense == driverLicense);
        }
    }
}
