using AutoMapper;
using AutoMapper.QueryableExtensions;
using Azure;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Helpers;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.Abstracts.WebUsers;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.WebUserR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.Abstracts.WebUserS
{
    public class WebUserProfileService : GenericService<WebUserProfile, WebUserProfileResponseDTO, WebUserProfileRequestDTO, WebUserProfileFilterModel>, IWebUserProfileService
    {
        private readonly IWebUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public WebUserProfileService(IWebUserProfileRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<WebUserProfileResponseDTO, WebUserProfileFilterModel>> GetDynamicFilteredEntities(ResultDTO<WebUserProfileResponseDTO, WebUserProfileFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000, token);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<WebUserProfileResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
                if (result.List.Any())
                {
                    result.NotificationType = new NotificationDTO { ResultType = NotificationType.Success };
                    return result;
                }
                result.NotificationType = new NotificationDTO
                {
                    ResultType = NotificationType.Null,
                    Description = "Kriterlere uygun veri bulunamadı!!"
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
        public override async Task<NotificationDTO> CreateAsync(WebUserProfileRequestDTO DTO, CancellationToken token)
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
                    var entity = _mapper.Map<WebUserProfile>(DTO);
                    //entity.Guid = Guid.NewGuid().ToString(); 
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
    }
}
