using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts.Ticket
{
    public interface IGenericTicketRepository<T> : IGenericRepository<T> where T : BaseTicketModel
    {
        IQueryable<T> SearchByTicketName(string ticketName);
        IQueryable<T> SearchBySeatNumber(string seatNumber);
        IQueryable<T> SearchByDepartureDate(DateTime dateTime);
        IQueryable<T> SearchByArrivalDate(DateTime dateTime);
        IQueryable<T> GetTicketBetweenPriceRange(decimal first, decimal last);
        IQueryable<T> GetTicketNetCostDesc();
        IQueryable<T> GetTicketByPaymentStatus(PaymentStatus paymentStatus);
        IQueryable<T> GetTicketByCurrency(Currency currency);
    }
}
