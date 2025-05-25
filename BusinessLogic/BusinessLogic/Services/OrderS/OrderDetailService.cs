using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Activities;
using BusinessLogic.DTOs.Orders;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Orders;
using DataAccess.Entities.Models.Orders;
using DataAccess.Repositories.OrderR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.OrderS
{
    public class OrderDetailService : GenericService<ActivityTicketOrderDetail, OrderDetailResponseDTO, OrderDetailRequestDTO, OrderDetailFilterModel>, IOrderDetailService
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public OrderDetailService(IOrderDetailRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<OrderDetailResponseDTO, OrderDetailFilterModel>> GetDynamicFilteredEntities(ResultDTO<OrderDetailResponseDTO, OrderDetailFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<OrderDetailResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
