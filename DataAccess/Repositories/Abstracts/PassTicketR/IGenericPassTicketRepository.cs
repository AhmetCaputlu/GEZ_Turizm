using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.PassTickets;

namespace DataAccess.Repositories.Abstracts.PassTicket
{
    public interface IGenericPassTicketRepository: IGenericRepository<ActivityPassTicket>
    {
        IQueryable<ActivityPassTicket> GetPassTicketByPriceDesc();
        IQueryable<ActivityPassTicket> GetPassTicketByTotalCostDesc();
    }
}
