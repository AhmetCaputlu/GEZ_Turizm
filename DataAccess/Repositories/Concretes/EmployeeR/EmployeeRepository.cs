using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Employees;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Concretes.Employee;

namespace DataAccess.Repositories.Concretes.EmployeeR
{
    public class EmployeeRepository : GenericEmployeeRepository<Entities.Models.Employees.Employee, EmployeeFilterModel>,
          IEmployeeRepository
    {
        private readonly GezTurizmContext _context;

        public EmployeeRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<Entities.Models.Employees.Employee> GetDynamicFilteredEntities(EmployeeFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.CurrentPosition.HasValue)
            {
                filter = filter.Where(x => x.CurrentPosition == filterModel.CurrentPosition.Value);
            }

            return filter;
        }
    }
}
