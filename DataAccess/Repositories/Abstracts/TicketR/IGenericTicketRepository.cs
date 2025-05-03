using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Repositories.Abstracts.Ticket
{
    public interface IGenericTicketRepository : IGenericRepository<ActivityTicket>
    {
        IQueryable<ActivityTicket> GetDynamicTicketFilter(
            string? ticketName = null,
            string? seatNnumber = null,
            DateTime? datetimeDeparture = null,
            DateTime? datetimeArrival = null,
            decimal? first = null,
            decimal? last = null,
            PaymentStatus? paymentStatus = null,
            Currency? currency = null,
            bool? descendingNetCost = null,
            bool? descending = null
            );
    }
}
