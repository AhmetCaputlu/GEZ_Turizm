using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogic.DTOs.Tickets;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Repositories.TicketR;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.TicketS
{
    public class PassTicketService : GenericService<ActivityPassTicket, PassTicketResponseDTO, PassTicketRequestDTO, PassTicketFilterModel>, IPassTicketService
    {
        private readonly IPassTicketRepository _repository;
        private readonly IMapper _mapper;

        public PassTicketService(IPassTicketRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public override async Task<ResultDTO<PassTicketResponseDTO, PassTicketFilterModel>> GetDynamicFilteredEntities(ResultDTO<PassTicketResponseDTO, PassTicketFilterModel> result, CancellationToken token)
        {
            try
            {
                await Task.Delay(2000);
                result.List = await _repository.GetDynamicFilteredEntities(result.DynamicFilter)
                    .ProjectTo<PassTicketResponseDTO>(_mapper.ConfigurationProvider).ToListAsync(token);
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
