using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Repositories.Abstracts.TicketR
{
    public interface IPassTicketRepository: IGenericRepository<ActivityPassTicket,PassTicketFilterModel>
    {

    }
}
