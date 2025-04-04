using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Repositories.Abstracts
{
    public interface IRepository<T> where T : class,IEntity
    {
        IQueryable<T> GetAllEntities();
        IQueryable<T> GetAllActives();
        IQueryable<T> GetAllPassives();
        IQueryable<T> GetAllUnknowns();
        IQueryable<T> GetAllUpdated();
        IQueryable<T> GetAllNotUpdated();
        Task<T> GetByIdAsync(int Id);
        IQueryable<T> GetEntitiesBetweenId(int firstId, int lastId);
        IQueryable<T> GetEntitiesByCreatedDate(DateTime dateTime);
        IQueryable<T> GetEntitiesByUpdatedDate(DateTime dateTime);
        IQueryable<T> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate);
        IQueryable<T> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate); 
        Task CreateAsync(T entity);
        Task CreateRangeAsync(IEnumerable<T> entities);
        Task CreateBulkAsync(IEnumerable<T> values);
        Task Update(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);
        Task UpdateBulkAsync(IEnumerable<T> values);
        Task DeleteAsync(int Id);
        Task DeleteRangeSelectAsync(int first,int last);
        Task DeleteRangeAsync(IEnumerable<T> values);
        Task DestroyAsync(int Id);
        Task DestroyRangeSelectAsync(int first,int last);
        Task DestroyRangeAsync(IEnumerable<T> entities);
        Task DestroyBulkAsync(IEnumerable<T> values);

    }
}
