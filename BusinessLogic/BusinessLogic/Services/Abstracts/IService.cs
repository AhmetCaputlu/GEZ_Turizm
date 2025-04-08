using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.Services.Abstracts
{
    public interface IService<T> where T : class,IEntity
    {
        IEnumerable<T> GetAllEntities();
        IEnumerable<T> GetAllActives();
        IEnumerable<T> GetAllPassives();
        IEnumerable<T> GetAllUnknowns();
        IEnumerable<T> GetAllUpdated();
        IEnumerable<T> GetAllNotUpdated();
        Task<T> GetByIdAsync(int Id);
        IEnumerable<T> GetEntitiesBetweenId(int firstId, int lastId);
        IEnumerable<T> GetEntitiesByCreatedDate(DateTime dateTime);
        IEnumerable<T> GetEntitiesByUpdatedDate(DateTime dateTime);
        IEnumerable<T> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate);
        IEnumerable<T> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate);
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> entities);
        Task CreateBulkAsync(List<T> values);
        Task Update(T entity);
        Task UpdateRangeAsync(List<T> entities);
        Task UpdateBulkAsync(List<T> values);
        Task DeleteAsync(int Id);
        Task DeleteRangeSelectAsync(int first, int last);
        Task DeleteRangeAsync(List<T> values);
        Task DestroyAsync(int Id);
        Task DestroyRangeSelectAsync(int first, int last);
        Task DestroyRangeAsync(List<T> entities);
        Task DestroyBulkAsync(List<T> values);
    }
}
