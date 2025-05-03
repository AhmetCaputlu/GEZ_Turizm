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

        public IQueryable<ActivityTicket> GetDynamicTicketFilter(string? ticketName = null, string? seatNnumber = null, DateTime? datetimeDeparture = null, DateTime? datetimeArrival = null, decimal? first = null, decimal? last = null, PaymentStatus? paymentStatus = null, Currency? currency = null, bool? descendingNetCost = null, bool? descending = null)
        {
            IQueryable<ActivityTicket> filter = _context.ActivityTickets;
            if (!string.IsNullOrEmpty(ticketName))
            {
                filter = filter.Where(x => x.TicketHolderName.ToLower().Contains(ticketName.ToLower()));
            }
            if (!string.IsNullOrEmpty(seatNnumber))
            {
                filter = filter.Where(x => x.SeatNumber.ToLower().Contains(seatNnumber.ToLower()));
            }
            if (datetimeDeparture.HasValue)
            {
                filter = filter.Where(x => x.DepartureDate.Date == datetimeDeparture.Value.Date);
            }
            if (datetimeArrival.HasValue)
            {
                filter = filter.Where(x => x.ArrivalDate.Date == datetimeArrival.Value.Date);
            }
            if (first.HasValue && last.HasValue)
            {
                filter = filter.Where(x => x.NetCost <= first.Value && x.NetCost >= last.Value);
            }
            else if (first.HasValue)
            {
                filter = filter.Where(x => x.NetCost >= first.Value);
            }
            else if (last.HasValue)
            {
                filter = filter.Where(x => x.NetCost <= last.Value);
            }
            if (paymentStatus.HasValue)
            {
                filter = filter.Where(x => x.PaymentStatus == paymentStatus.Value);
            }
            if (currency.HasValue)
            {
                filter = filter.Where(x => x.Currency == currency.Value);
            }
            if (descendingNetCost == true)
            {
                filter = filter.OrderByDescending(x => x.NetCost);
            }
            else if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
