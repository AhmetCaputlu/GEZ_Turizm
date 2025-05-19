using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.PassTickets;
using DataAccess.Entities.Models.PassTickets;

namespace DataAccess.Repositories.Abstracts.PassTicket
{
    public interface IGenericPassTicketRepository: IGenericRepository<ActivityPassTicket,PassTicketFilterModel>
    {

    }
}
