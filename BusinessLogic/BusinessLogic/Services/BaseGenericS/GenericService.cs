using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.Helpers;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.BaseGenericS
{
    public class GenericService<TEntity, TResponse, TRequest, TFilterEntity> :
        IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : class, IEntity where TResponse : BaseResponseModelDTO
        where TRequest : BaseRequestModelDTO where TFilterEntity : BaseFilterModel, new()
    {
        private readonly IGenericRepository<TEntity, TFilterEntity> _repository;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository<TEntity, TFilterEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region Manuel Methods
        //public IEnumerable<TResponse> GetAllEntities()
        //{
        //    return _repository.GetAllEntities().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllActives()
        //{
        //    return _repository.GetAllActives().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllPassives()
        //{
        //    return _repository.GetAllPassives().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllUnknowns()
        //{
        //    return _repository.GetAllUnknowns().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllUpdated()
        //{
        //    return _repository.GetAllUpdated().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetAllNotUpdated()
        //{
        //    return _repository.GetAllNotUpdated().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}

        //public IEnumerable<TResponse> GetEntitiesBetweenId(int firstId, int lastId)
        //{
        //    return _repository.GetEntitiesBetweenId(firstId,lastId).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesByCreatedDate(DateTime dateTime)
        //{
        //    return _repository.GetEntitiesByCreatedDate(dateTime).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesByUpdatedDate(DateTime dateTime)
        //{
        //    return _repository.GetEntitiesByUpdatedDate(dateTime).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesBetweenCreatedDates(DateTime firstDate, DateTime lastDate)
        //{
        //    return _repository.GetEntitiesBetweenCreatedDates(firstDate, lastDate).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //}
        //public IEnumerable<TResponse> GetEntitiesBetweenUpdatedDates(DateTime firstDate, DateTime lastDate)
        //{
        //    return _repository.GetEntitiesBetweenUpdatedDates(firstDate, lastDate).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToList();
        //} 
        #endregion
        /// <summary>
        /// Dinamik filtreleme için kullanılır.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public virtual async Task<ResultDTO<TResponse, TFilterEntity>> GetDynamicFilteredEntities(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToListAsync(token);
                if (result.List.Any())
                {
                    result.NotificationType = new NotificationDTO { ResultType = NotificationType.Success };

                    return result;
                }
                result.NotificationType = new NotificationDTO
                {
                    ResultType = NotificationType.Null,
                    Description = "Kriterlere uygun kullanıcı bulunamadı!!"
                };
                return result;
            }
            catch (OperationCanceledException oce)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
                return result;
            }
            catch (Exception ex)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
                return result;
            }
        }
        /// <summary>
        /// Tüm aktif kullanıcıları döndürür.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultDTO<TResponse, TFilterEntity>> GetAllActives(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token)
        {
            try
            {
                result.List = await _repository.GetAllActives().ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToListAsync();
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.Success };
                return result;
            }
            catch (OperationCanceledException oce)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
                return result;
            }
            catch (Exception ex)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
                return result;
            }

        }
        /// <summary>
        /// Kullanıcı Id bilgisine göre kullanıcıyı döndürür.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public async Task<ResultDTO<TResponse, TFilterEntity>> GetByIdAsync(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                if (result.FilterId.HasValue)
                {
                    var selectedEntity = await _repository.GetByIdAsync(result.FilterId, token);
                    if (selectedEntity != null)
                    {
                        result.SelectedEntity = _mapper.Map<TResponse>(selectedEntity);
                        result.NotificationType = new NotificationDTO { ResultType = NotificationType.Success };
                        return result;
                    }
                    result.NotificationType = new NotificationDTO { ResultType = NotificationType.Null, Description = "Aranan Id verisine uygun veri bulunamadı !" };
                    return result;
                }
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.Null, Description = "Id bilgisi boş gönderilmiş!" };
                return result;
            }
            catch (OperationCanceledException oce)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
                return result;
            }
            catch (Exception ex)
            {
                result.NotificationType = new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
                return result;
            }

        }
        /// <summary>
        /// Veritabanına yeni bir veri eklemek için kullanılır.
        /// </summary>
        /// <param name="DTO"></param>
        /// <returns></returns>
        public virtual async Task<NotificationDTO> CreateAsync(TRequest DTO, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                if (DTO == null)
                {
                    return new NotificationDTO
                    {
                        ResultType = NotificationType.Null,
                        Description = "Kayıt için bilgiler boş gönderilmiş.Lütfen kontrol edin!"
                    };
                }
                else
                {
                    var entity = _mapper.Map<TEntity>(DTO);
                    entity.Guid = Guid.NewGuid().ToString();
                    entity.CreatedDate = DateTime.Now;
                    entity.CreatedID = UniqueIdentify.GetUserID();
                    entity.CreatedIPAddress = IPAdress.GetIpAdress();
                    entity.IsUpdated = false;

                    await _repository.CreateAsync(entity, token);
                    return new NotificationDTO
                    {
                        ResultType = NotificationType.Success,
                        Description = "Veritabanı kaydı başarıyla tamamlandı!"
                    };
                }
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Veritabanına çoklu veri eklemek için kullanılır.
        /// </summary>
        /// <param name="DTOs"></param>
        /// <returns></returns>
        public async Task<NotificationDTO> CreateRangeAsync(List<TRequest> DTOs, CancellationToken token)
        {
            try
            {
                await Task.Delay(4000, token);
                if (DTOs.Count == 0)
                {
                    return new NotificationDTO
                    {
                        ResultType = NotificationType.Null,
                        Description = "Kayıt için bilgiler boş gönderilmiş.Lütfen kontrol edin!"
                    };
                }
                else
                {
                    var entities = _mapper.Map<List<TEntity>>(DTOs);

                    foreach (var entity in entities)
                    {
                        entity.Guid = Guid.NewGuid().ToString();
                        entity.CreatedDate = DateTime.Now;
                        entity.CreatedID = UniqueIdentify.GetUserID();
                        entity.CreatedIPAddress = IPAdress.GetIpAdress();
                        entity.IsUpdated = false;
                    }

                    await _repository.CreateRangeAsync(entities, token);
                    return new NotificationDTO
                    {
                        ResultType = NotificationType.Success,
                        Description = "Veritabanı kayıtları başarıyla tamamlandı!"
                    };
                }
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Veritabanında kayıtlı verinin güncellenmesini sağlar.
        /// </summary>
        /// <param name="DTO"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<NotificationDTO> UpdateAsync(TRequest DTO, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                var updatedEntity = await _repository.GetByIdAsync(DTO.Id, token);
                if (updatedEntity != null)
                {
                    updatedEntity.IsUpdated = true;
                    updatedEntity.UpdatedDate = DateTime.Now;
                    updatedEntity.UpdatedID = UniqueIdentify.GetUserID();
                    updatedEntity.UpdatedIPAddress = IPAdress.GetIpAdress();
                    _mapper.Map(DTO, updatedEntity);
                    await _repository.Update(updatedEntity, token);

                    return new NotificationDTO { ResultType = NotificationType.Success, Description = "Veri başarıyla güncellendi!" };
                }
                return new NotificationDTO { ResultType = NotificationType.Null, Description = "Aranan Id verisine uygun veri bulunamadı !" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Veritabanında kayıtlı verilerin güncellenmesini sağlar.
        /// </summary>
        /// <param name="DTOs"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<NotificationDTO> UpdateRangeAsync(List<TRequest> DTOs, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                var updatedList = new List<TEntity>();
                if (DTOs.Count > 0)
                {
                    foreach (var dto in DTOs)
                    {
                        var updatedEntity = await _repository.GetByIdAsync(dto.Id, token);
                        _mapper.Map(dto, updatedEntity);
                        updatedEntity.IsUpdated = true;
                        updatedEntity.UpdatedDate = DateTime.Now;
                        updatedEntity.UpdatedID = UniqueIdentify.GetUserID();
                        updatedEntity.UpdatedIPAddress = IPAdress.GetIpAdress();
                        updatedList.Add(updatedEntity);
                    }
                    await _repository.UpdateRangeAsync(updatedList, token);

                    return new NotificationDTO { ResultType = NotificationType.Success, Description = "Güncellemeler başarıyla tamamlandı!" };
                }
                return new NotificationDTO { ResultType = NotificationType.Null, Description = "Liste boş gönderilmiş!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Veritabanındaki verinin status bilgisini pasif olarak değiştirir.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<NotificationDTO> DeleteAsync(int Id, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                var deleted = await _repository.GetByIdAsync(Id, token);
                if (deleted != null)
                {
                    await _repository.DeleteAsync(deleted, token);
                    return new NotificationDTO { ResultType = NotificationType.Success, Description = $"Veri Başarıyla silindi!" };
                }
                return new NotificationDTO { ResultType = NotificationType.Null, Description = "Veri bulunamadı!!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Veritabanındaki verilerin status bilgisini pasif olarak değiştirir.
        /// </summary>
        /// <param name="DTOs"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<NotificationDTO> DeleteRangeAsync(List<TRequest> DTOs, CancellationToken token)
        {
            try
            {
                await Task.Delay(4000, token);
                if (DTOs.Count > 0)
                {
                    await _repository.DeleteRangeAsync(_mapper.Map<List<TEntity>>(DTOs), token);
                    return new NotificationDTO { ResultType = NotificationType.Success, Description = $"Veriler başarıyla silindi!" };
                }
                return new NotificationDTO { ResultType = NotificationType.Null, Description = "Silinecek listede veri bulunamadı!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Seçilen veri veritabanından silinir.Veriye tekrar erişim sağlanamaz!
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<NotificationDTO> DestroyAsync(int Id, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                var destroyedItem = await _repository.GetByIdAsync(Id, token);
                if (destroyedItem != null)
                {
                    await _repository.DestroyAsync(destroyedItem, token);
                    return new NotificationDTO
                    {
                        ResultType = NotificationType.Success,
                        Description = "Veri başarıyla veritabanından silindi!"
                    };
                }
                return new NotificationDTO { ResultType = NotificationType.Null, Description = "Id bilgisine uygun veri bulunamadı!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Seçilen veriler veritabanından silinir.Veriye tekrar erişim sağlanamaz!
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<NotificationDTO> DestroyRangeAsync(List<TEntity> entities, CancellationToken token)
        {
            try
            {
                await Task.Delay(4000, token);
                if (entities.Count > 0)
                {
                    await _repository.DeleteRangeAsync(entities, token);
                    return new NotificationDTO
                    {
                        ResultType = NotificationType.Success,
                        Description = "Veriler başarıyla veritabanından silindi!"
                    };
                }
                return new NotificationDTO { ResultType = NotificationType.Null, Description = "Listede herhangi bir veri bulunamadı!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationDTO { ResultType = NotificationType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationDTO { ResultType = NotificationType.UnknownError, Description = $"Bilinmeyen bir hata meydana geldi!\n{ex.Message}" };
            }
        }
    }
}
