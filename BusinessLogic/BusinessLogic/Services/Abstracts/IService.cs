using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.Services.Abstracts
{
    public interface IService<TEntity, TResponse, TRequest>
        where TEntity : class, IEntity where TResponse : BaseResponseModelDTO where TRequest : BaseRequestModelDTO
    {
        #region Manuel Methods
        //IEnumerable<TResponse> GetAllEntities();
        //IEnumerable<TResponse> GetAllActives();
        //IEnumerable<TResponse> GetAllPassives();
        //IEnumerable<TResponse> GetAllUnknowns();
        //IEnumerable<TResponse> GetAllUpdated();
        //IEnumerable<TResponse> GetAllNotUpdated();
        //IEnumerable<TResponse> GetEntitiesBetweenId(int firstId, int lastId);
        //IEnumerable<TResponse> GetEntitiesByCreatedDate(DateTime dateTime);
        //IEnumerable<TResponse> GetEntitiesByUpdatedDate(DateTime dateTime);
        //IEnumerable<TResponse> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate);
        //IEnumerable<TResponse> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate); 
        #endregion
        Task<IEnumerable<TResponse>> GetDynamicFilteredEntities(
             int? firstId = null,
             int? lastId = null,
             DateTime? firstCreatedDate = null,
             DateTime? secondCreatedDate = null,
             DateTime? firstUpdatedDate = null,
             DateTime? secondUpdatedDate = null,
             DataStatus? status = null,
             bool? isUpdated = null,
             bool? descending = null
             );
        Task<TResponse> GetByIdAsync(int Id);
        Task CreateAsync(TRequest DTO);
        Task CreateRangeAsync(List<TRequest> DTOs);
        Task CreateBulkAsync(List<TRequest> DTOs);
        Task Update(TRequest DTO);
        Task UpdateRangeAsync(List<TRequest> DTOs);
        Task UpdateBulkAsync(List<TRequest> DTOs);
        Task DeleteAsync(int Id);
        Task DeleteRangeSelectAsync(int first, int last);
        Task DeleteRangeAsync(List<TRequest> DTOs);
        Task DestroyAsync(int Id);
        Task DestroyRangeSelectAsync(int first, int last);
        Task DestroyRangeAsync(List<TEntity> entities);
        Task DestroyBulkAsync(List<TEntity> values);
    }
}
