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

        public IQueryable<T> GetDynamicEmployeeFilter(string? name = null, Gender? gender = null, DateTime? dateTimeBirth = null, int? age = null, DateTime? dateTimeHire = null, int? exp = null, bool? descending = null)
        {
            IQueryable<T> filter = _dbset;

            if (!string.IsNullOrEmpty(name))
            {
                filter = filter.Where(x => x.FullName.ToLower().Contains(name.ToLower()));
            }
            if (gender.HasValue)
            {
                filter = filter.Where(x => x.Gender == gender.Value);
            }
            if (dateTimeBirth.HasValue)
            {
                filter = filter.Where(x => x.BirthDate.Date == dateTimeBirth.Value.Date);
            }
            if (age.HasValue)
            {
                filter = filter.Where(x => (x.Age ?? 0) == age.Value);
            }
            if (dateTimeHire.HasValue)
            {
                filter = filter.Where(x => x.HireDate.Date == dateTimeHire.Value.Date);
            }
            if (exp.HasValue)
            {
                filter = filter.Where(x => x.Experience == exp.Value);
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
