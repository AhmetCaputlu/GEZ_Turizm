using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts.Employee
{
    public interface IGenericEmployeeRepository<T> : IGenericRepository<T> where T : BaseEmployeeModel
    {
        IQueryable<T> SearchEmployeeByName(string name);
        IQueryable<T> GetAllEmployeesbyGender(Gender gender);
        IQueryable<T> GetEmployeesByBirthDate(DateTime dateTime);
        IQueryable<T> GetEmployeesByAge(int age);
        IQueryable<T> GetEmployeesByHireDate(DateTime dateTime);
        IQueryable<T> GetEmployeesByHigherExperience(int exp);
    }
}
