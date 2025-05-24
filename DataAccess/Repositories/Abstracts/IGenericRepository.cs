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
        IQueryable<TEntity> GetDynamicFilteredEntities(TFilterEntity filterModel, CancellationToken token);
        Task<TEntity> GetByIdAsync(int? Id, CancellationToken token);
        Task CreateAsync(TEntity entity, CancellationToken token);
        Task CreateRangeAsync(List<TEntity> entities, CancellationToken token);
        Task Update(TEntity entity, CancellationToken token);
        Task UpdateRangeAsync(List<TEntity> entities, CancellationToken token);
        Task DeleteAsync(TEntity entity, CancellationToken token);
        Task DeleteRangeAsync(List<TEntity> values, CancellationToken token);
        Task DestroyAsync(TEntity entity, CancellationToken token);
        Task DestroyRangeAsync(List<TEntity> entities, CancellationToken token);
    }
}
