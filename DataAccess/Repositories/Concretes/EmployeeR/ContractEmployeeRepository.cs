using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.Employee;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Concretes.Employee;

namespace DataAccess.Repositories.Concretes.EmployeeR
{
    public class ContractEmployeeRepository : GenericEmployeeRepository<ContractEmployee, ContractEmployeeFilterModel>, IContractEmployeeRepository
    {
        private readonly GezTurizmContext _context;
        public ContractEmployeeRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<ContractEmployee> GetDynamicFilteredEntities(ContractEmployeeFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.DriverLicense.HasValue)
            {
                filter = filter.Where(x => (x.DriverLicense ?? DriverLicense.None) == filterModel.DriverLicense.Value);
            }
            if (filterModel.Language.HasValue)
            {
                filter = filter.Where(x => (x.Language ?? Language.None) == filterModel.Language.Value);
            }

            return filter;
        }
    }
}
