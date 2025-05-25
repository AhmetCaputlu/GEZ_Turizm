using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.FilterModels.Employees;

namespace DataAccess.Repositories.EmployeeR
{
    public interface IGenericEmployeeRepository<TEntity, TFilteredEntity> : IGenericRepository<TEntity, TFilteredEntity> where TEntity : BaseEmployeeModel where TFilteredEntity : BaseEmployeeFilterModel
    {
        
    }
}
