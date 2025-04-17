using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Repositories.Abstracts.Ticket
{
    public interface IGenericTicketRepository : IGenericRepository<ActivityTicket>
    {
        IQueryable<ActivityTicket> SearchByTicketName(string ticketName);
        IQueryable<ActivityTicket> SearchBySeatNumber(string seatNumber);
        IQueryable<ActivityTicket> SearchByDepartureDate(DateTime dateTime);
        IQueryable<ActivityTicket> SearchByArrivalDate(DateTime dateTime);
        IQueryable<ActivityTicket> GetTicketBetweenPriceRange(decimal first, decimal last);
        IQueryable<ActivityTicket> GetTicketNetCostDesc();
        IQueryable<ActivityTicket> GetTicketByPaymentStatus(PaymentStatus paymentStatus);
        IQueryable<ActivityTicket> GetTicketByCurrency(Currency currency);
    }
}
