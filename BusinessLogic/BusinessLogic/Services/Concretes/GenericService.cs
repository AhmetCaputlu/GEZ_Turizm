using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Helpers;
using BusinessLogic.OperationResult;
using BusinessLogic.OperationResult.Enums;
using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Interfaces;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.Concretes
{
    public class GenericService<TEntity, TResponse, TRequest, TFilterEntity> :
        IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : class, IEntity where TResponse : BaseResponseModelDTO where TRequest : BaseRequestModelDTO
        where TFilterEntity : BaseFilterModel
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
        /// Listeleme işlemlerinde dinamik filtreleme işlemleri için kullanılır.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public virtual async Task<ResultDTO<TResponse, TFilterEntity>> GetDynamicFilteredEntities(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                if (result.DynamicFilter == null)
                {
                    result.NotificationType = new NotificationDTO
                    {
                        ResultType = NotificationType.Null,
                        Description = "Kriter belirtilmemiş!"
                    };
                    return result;
                }
                else
                {
                    result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter).ProjectTo<TResponse>(_mapper.ConfigurationProvider).ToListAsync();
                    if (!result.List.Any())
                    {
                        result.NotificationType = new NotificationDTO
                        {
                            ResultType = NotificationType.NullUser,
                            Description = "Kriterlere uygun kullanıcı bulunamadı!!"
                        };
                        return result;
                    }
                    result.NotificationType = new NotificationDTO { ResultType = NotificationType.Success };
                }
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
        /// Kullanıcı Id bilgisine göre sadece o kullanıcıyı döndürür.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public async Task<ResultDTO<TResponse, TFilterEntity>> GetByIdAsync(ResultDTO<TResponse, TFilterEntity> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                if (result.FilterId.HasValue)
                {
                    var selectedEntity = await _repository.GetByIdAsync(result.FilterId);
                    if (selectedEntity != null)
                    {
                        result.SelectedEntity = _mapper.Map<TResponse>(selectedEntity);
                        result.NotificationType = new NotificationDTO { ResultType = NotificationType.Success };
                        return result;
                    }
                    result.NotificationType = new NotificationDTO { ResultType = NotificationType.NullUser, Description = "Aranan bilgiye uygun kullanıcı bulunamadı !" };
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
                await Task.Delay(2000);
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

                    entity.CreatedDate = DateTime.Now;
                    entity.CreatedID = UniqueIdentify.GetUserID();
                    entity.CreatedIPAddress = IPAdress.GetIpAdress();
                    entity.IsUpdated = false;

                    await _repository.CreateAsync(entity);
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
                await Task.Delay(4000);
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

                    await _repository.CreateRangeAsync(entities);
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
        public async Task<NotificationDTO> UpdateAsync(TRequest DTO, CancellationToken token)
        {

            await _repository.Update(_mapper.Map<TEntity>(DTO));
        }
        public async Task UpdateRangeAsync(List<TRequest> DTOs)
        {
            await _repository.UpdateRangeAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task UpdateBulkAsync(List<TRequest> DTOs)
        {
            await _repository.UpdateBulkAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task DeleteAsync(int Id)
        {
            await _repository.DeleteAsync(Id);
        }
        public async Task DeleteRangeSelectAsync(int first, int last)
        {
            await _repository.DeleteRangeSelectAsync(first, last);
        }
        public async Task DeleteRangeAsync(List<TRequest> DTOs)
        {
            await _repository.DeleteRangeAsync(_mapper.Map<List<TEntity>>(DTOs));
        }
        public async Task DestroyAsync(int Id)
        {
            await _repository.DestroyAsync(Id);
        }
        public async Task DestroyRangeSelectAsync(int first, int last)
        {
            await _repository.DestroyRangeSelectAsync(first, last);
        }
        public async Task DestroyRangeAsync(List<TEntity> entities)
        {
            await _repository.DestroyRangeAsync(entities);
        }
        public async Task DestroyBulkAsync(List<TEntity> values)
        {
            await _repository.DestroyBulkAsync(values);
        }
    }
}
