using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Repositories.TicketR
{
    public interface ITicketRepository : IGenericRepository<ActivityTicket, TicketFilterModel>
    {
    
    }
}
