using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Repositories.Abstracts
{
    public interface IGenericRepository<TEntity, TFilterEntity> where TEntity : class, IEntity
        where TFilterEntity : BaseFilterModel
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
        IQueryable<TEntity> GetDynamicFilteredEntities(TFilterEntity filterModel);
        Task<TEntity?> GetByIdAsync(int? Id);
        Task CreateAsync(TEntity entity);
        Task CreateRangeAsync(List<TEntity> entities);
        Task CreateBulkAsync(List<TEntity> values);
        Task Update(TEntity entity);
        Task UpdateRangeAsync(List<TEntity> entities);
        Task UpdateBulkAsync(List<TEntity> values);
        Task DeleteAsync(int Id);
        Task DeleteRangeSelectAsync(int first, int last);
        Task DeleteRangeAsync(List<TEntity> values);
        Task DestroyAsync(int Id);
        Task DestroyRangeSelectAsync(int first, int last);
        Task DestroyRangeAsync(List<TEntity> entities);
        Task DestroyBulkAsync(List<TEntity> values);

    }
}
