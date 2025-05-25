using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Activities;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.Abstracts.Activities;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Activities;
using DataAccess.Repositories.ActivityR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.Abstracts.ActivityS
{
    public class ActivityService : GenericService<DataAccess.Entities.Models.Activities.Activity, ActivityResponseDTO, ActivityRequestDTO, ActivityFilterModel>, IActivityService
    {
        private readonly IActivityRepository _repository;
        private readonly IMapper _mapper;
        public ActivityService(IActivityRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<ActivityResponseDTO, ActivityFilterModel>> GetDynamicFilteredEntities(ResultDTO<ActivityResponseDTO, ActivityFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<ActivityResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
    }
}
