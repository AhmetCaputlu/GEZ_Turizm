using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Concretes.Employee;

namespace DataAccess.Repositories.Concretes.EmployeeR
{
    public class EmployeeRepository : GenericEmployeeRepository<DataAccess.Entities.Models.Employees.Employee>,
          IEmployeeRepository
    {
        private readonly GezTurizmContext _context;

        public EmployeeRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Entities.Models.Employees.Employee> GetDynamicEmployeesFilter(Department? department = null, bool? descending = null)
        {
            IQueryable<Entities.Models.Employees.Employee> filter = _context.Employees;
            if (department.HasValue)
            {
                filter = filter.Where(x => x.CurrentPosition == department.Value);
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
