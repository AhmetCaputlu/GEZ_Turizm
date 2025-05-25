using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Regions;
using BusinessLogic.DTOs.Tickets;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Repositories.TicketR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.TicketS
{
    public class TicketService : GenericService<ActivityTicket, TicketResponseDTO, TicketRequestDTO, TicketFilterModel>, ITicketService
    {
        private readonly ITicketRepository _repository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<TicketResponseDTO, TicketFilterModel>> GetDynamicFilteredEntities(ResultDTO<TicketResponseDTO, TicketFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<TicketResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
