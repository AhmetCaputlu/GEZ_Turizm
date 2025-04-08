using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts
{
    public interface IEmployeeRepository<T> : IRepository<T> where T : BaseEmployeeModel
    {
        IQueryable<T> SearchEmployeeByName(string name);
        IQueryable<T> GetAllEmployeesbyGender(Gender gender);
        IQueryable<T> GetEmployeesByBirthDate(DateTime dateTime);
        IQueryable<T> GetEmployeesByAge(int age);
        IQueryable<T> GetEmployeesByHireDate(DateTime dateTime);
        IQueryable<T> GetEmployeesByHigherExperience(int exp);
    }
}
