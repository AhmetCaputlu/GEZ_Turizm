using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts.Employee
{
    public interface IGenericEmployeeRepository<T> : IGenericRepository<T> where T : BaseEmployeeModel
    {
        IQueryable<T> GetDynamicEmployeeFilter(string? name = null, Gender? gender = null, DateTime? dateTimeBirth = null,
            int? age = null, DateTime? dateTimeHire = null, int? exp = null, bool? descending = null);
    }
}
