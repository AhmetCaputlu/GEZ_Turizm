using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.Services.BaseGenericS
{
    public interface IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : class, IEntity where TResponse : BaseResponseModelDTO where TRequest : BaseRequestModelDTO
        where TFilterEntity : BaseFilterModel,new()
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
        /// Dinamik filtreleme için kullanılır.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        Task<ResultDTO<TResponse, TFilterEntity>> GetDynamicFilteredEntities(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token);
        /// <summary>
        /// Tüm aktif kullanıcıları döndürür.
        /// </summary>
        /// <returns></returns>
        Task<ResultDTO<TResponse, TFilterEntity>> GetAllActives(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token);
        /// <summary>
        /// Kullanıcı Id bilgisine göre kullanıcıyı döndürür.
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
        /// <summary>
        /// Veritabanında kayıtlı verinin güncellenmesini sağlar.
        /// </summary>
        /// <param name="DTO"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<NotificationDTO> UpdateAsync(TRequest DTO, CancellationToken token);
        /// <summary>
        /// Veritabanında kayıtlı verilerin güncellenmesini sağlar.
        /// </summary>
        /// <param name="DTOs"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<NotificationDTO> UpdateRangeAsync(List<TRequest> DTOs, CancellationToken token);
        /// <summary>
        /// Veritabanındaki verinin status bilgisini pasif olarak değiştirir.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<NotificationDTO> DeleteAsync(int Id, CancellationToken token);
        /// <summary>
        /// Veritabanındaki verilerin status bilgisini pasif olarak değiştirir.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<NotificationDTO> DeleteRangeAsync(List<TRequest> DTOs, CancellationToken token);
        /// <summary>
        /// Seçilen veri veritabanından silinir.Veriye tekrar erişim sağlanamaz!
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<NotificationDTO> DestroyAsync(int Id, CancellationToken token);
        /// <summary>
        /// Seçilen veriler veritabanından silinir.Veriye tekrar erişim sağlanamaz!
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<NotificationDTO> DestroyRangeAsync(List<TEntity> entities, CancellationToken token);
    }
}
