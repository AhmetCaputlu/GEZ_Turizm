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

        public IQueryable<Entities.Models.Employees.Employee> GetEmployeesByCurrentPosition(Department department)
        {
            return _context.Employees.Where(x => x.CurrentPosition == department);
        }

        public IQueryable<Entities.Models.Employees.Employee> GetEmployeesByTotalDaysDesc()
        {
            return _context.Employees.OrderByDescending(x => x.DaysWorked);
        }
    }
}
