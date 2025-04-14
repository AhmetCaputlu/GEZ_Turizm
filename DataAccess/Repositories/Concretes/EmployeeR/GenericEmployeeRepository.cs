using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.Employee;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Employee
{
    public class GenericEmployeeRepository<T> : GenericRepository<T>, IGenericEmployeeRepository<T> where T : BaseEmployeeModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericEmployeeRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> SearchEmployeeByName(string name)
        {
            return _dbset.Where(x => x.FullName.ToLower().Contains(name.ToLower()));
        }

        public IQueryable<T> GetAllEmployeesbyGender(Gender gender)
        {
            return _dbset.Where(x => x.Gender == gender);
        }

        public IQueryable<T> GetEmployeesByBirthDate(DateTime dateTime)
        {
            return _dbset.Where(x => x.BirthDate.Date == dateTime.Date);
        }

        public IQueryable<T> GetEmployeesByAge(int age)
        {
            return _dbset.Where(x => x.Age == age);
        }

        public IQueryable<T> GetEmployeesByHireDate(DateTime dateTime)
        {
            return _dbset.Where(x => x.HireDate.Date == dateTime.Date);
        }

        public IQueryable<T> GetEmployeesByHigherExperience(int exp)
        {
            return _dbset.Where(x => x.Experience > exp);
        }
    }
}
