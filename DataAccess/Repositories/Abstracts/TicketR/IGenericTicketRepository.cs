using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Repositories.Abstracts.Ticket
{
    public interface IGenericTicketRepository : IGenericRepository<ActivityTicket, TicketFilterModel>
    {
    
    }
}
