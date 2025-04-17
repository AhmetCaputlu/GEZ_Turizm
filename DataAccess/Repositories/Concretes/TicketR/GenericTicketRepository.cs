using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Repositories.Abstracts.Ticket;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Ticket
{
    public class GenericTicketRepository : GenericRepository<ActivityTicket>, IGenericTicketRepository
    {
        private readonly GezTurizmContext _context;
        public GenericTicketRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<ActivityTicket> SearchByTicketName(string ticketName)
        {
            return _context.ActivityTickets.Where(x => x.TicketHolderName.ToLower().Contains(ticketName.ToLower()));
        }

        public IQueryable<ActivityTicket> SearchBySeatNumber(string seatNumber)
        {
            return _context.ActivityTickets.Where(x => x.SeatNumber.ToLower().Contains(seatNumber.ToLower()));

        }

        public IQueryable<ActivityTicket> SearchByDepartureDate(DateTime dateTime)
        {
            return _context.ActivityTickets.Where(x => x.DepartureDate.Date == dateTime.Date);
        }

        public IQueryable<ActivityTicket> SearchByArrivalDate(DateTime dateTime)
        {
            return _context.ActivityTickets.Where(x => x.ArrivalDate.Date == dateTime.Date);
        }

        public IQueryable<ActivityTicket> GetTicketBetweenPriceRange(decimal first, decimal last)
        {
            return _context.ActivityTickets.Where(x => x.Price >= first && x.Price <= last);
        }

        public IQueryable<ActivityTicket> GetTicketNetCostDesc()
        {
            return _context.ActivityTickets.OrderByDescending(x => x.NetCost);
        }

        public IQueryable<ActivityTicket> GetTicketByPaymentStatus(PaymentStatus paymentStatus)
        {
            return _context.ActivityTickets.Where(x => x.PaymentStatus == paymentStatus);
        }

        public IQueryable<ActivityTicket> GetTicketByCurrency(Currency currency)
        {
            return _context.ActivityTickets.Where(x => x.Currency == currency);

        }
    }
}
