using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Repositories.Abstracts
{
    public interface IGenericRepository<T> where T : class,IEntity
    {
        #region Manuel Methods
        //IQueryable<T> GetAllEntities();
        //IQueryable<T> GetAllActives();
        //IQueryable<T> GetAllPassives();
        //IQueryable<T> GetAllUnknowns();
        //IQueryable<T> GetAllUpdated();
        //IQueryable<T> GetAllNotUpdated();
        //IQueryable<T> GetEntitiesBetweenId(int firstId, int lastId);
        //IQueryable<T> GetEntitiesByCreatedDate(DateTime dateTime);
        //IQueryable<T> GetEntitiesByUpdatedDate(DateTime dateTime);
        //IQueryable<T> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate);
        //IQueryable<T> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate); 
        #endregion
        IQueryable<T> GetDynamicFilteredEntities(
            int? firstId = null,
            int? lastId = null,
            DateTime? firstCreatedDate = null,
            DateTime? secondCreatedDate = null,
            DateTime? firstUpdatedDate = null,
            DateTime? secondUpdatedDate = null,
            DataStatus? status = null,
            bool? isUpdated = null);
            
        Task<T> GetByIdAsync(int Id);
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> entities);
        Task CreateBulkAsync(List<T> values);
        Task Update(T entity);
        Task UpdateRangeAsync(List<T> entities);
        Task UpdateBulkAsync(List<T> values);
        Task DeleteAsync(int Id);
        Task DeleteRangeSelectAsync(int first,int last);
        Task DeleteRangeAsync(List<T> values);
        Task DestroyAsync(int Id);
        Task DestroyRangeSelectAsync(int first,int last);
        Task DestroyRangeAsync(List<T> entities);
        Task DestroyBulkAsync(List<T> values);

    }
}
