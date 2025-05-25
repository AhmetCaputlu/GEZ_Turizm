using BusinessLogic.DTOs.Tickets;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;

namespace BusinessLogic.Services.TicketS
{
    public interface IPassTicketService : IGenericService<ActivityPassTicket, PassTicketResponseDTO, PassTicketRequestDTO, PassTicketFilterModel>
    {

    }
}
