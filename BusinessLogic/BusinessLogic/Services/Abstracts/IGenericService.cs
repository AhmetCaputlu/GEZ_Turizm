using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.Services.Abstracts
{
    public interface IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : class, IEntity where TResponse : BaseResponseModelDTO where TRequest : BaseRequestModelDTO
        where TFilterEntity : BaseFilterModel
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
        /// <summary>
        /// Listeleme işlemlerinde dinamik filtreleme işlemleri için kullanılır.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        Task<ResultDTO<TResponse, TFilterEntity>> GetDynamicFilteredEntities(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token);
        /// <summary>
        /// Kullanıcı Id bilgisine göre sadece o kullanıcıyı döndürür.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        Task<ResultDTO<TResponse, TFilterEntity>> GetByIdAsync(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token);
        /// <summary>
        /// Veritabanına yeni bir veri eklemek için kullanılır.
        /// </summary>
        /// <param name="DTO"></param>
        /// <returns></returns>
        Task<NotificationDTO> CreateAsync(TRequest DTO, CancellationToken token);
        /// <summary>
        /// Veritabanına çoklu veri eklemek için kullanılır.
        /// </summary>
        /// <param name="DTOs"></param>
        /// <returns></returns>
        Task<NotificationDTO> CreateRangeAsync(List<TRequest> DTOs, CancellationToken token);
        Task UpdateAsync(TRequest DTO, CancellationToken token);
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
