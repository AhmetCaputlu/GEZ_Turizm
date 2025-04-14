using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.Ticket;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Ticket
{
    public class GenericTicketRepository<T> : GenericRepository<T>, IGenericTicketRepository<T> where T : BaseTicketModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericTicketRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> SearchByTicketName(string ticketName)
        {
            return _dbset.Where(x => x.TicketName.ToLower().Contains(ticketName.ToLower()));
        }

        public IQueryable<T> SearchBySeatNumber(string seatNumber)
        {
            return _dbset.Where(x => x.SeatNumber.ToLower().Contains(seatNumber.ToLower()));

        }

        public IQueryable<T> SearchByDepartureDate(DateTime dateTime)
        {
            return _dbset.Where(x => x.DepartureDate.Date == dateTime.Date);
        }

        public IQueryable<T> SearchByArrivalDate(DateTime dateTime)
        {
            return _dbset.Where(x => x.ArrivalDate.Date == dateTime.Date);
        }

        public IQueryable<T> GetTicketBetweenPriceRange(decimal first, decimal last)
        {
            return _dbset.Where(x => x.Price >= first && x.Price <= last);
        }

        public IQueryable<T> GetTicketNetCostDesc()
        {
            return _dbset.OrderByDescending(x => x.NetCost);
        }

        public IQueryable<T> GetTicketByPaymentStatus(PaymentStatus paymentStatus)
        {
            return _dbset.Where(x => x.PaymentStatus == paymentStatus);
        }

        public IQueryable<T> GetTicketByCurrency(Currency currency)
        {
            return _dbset.Where(x => x.Currency == currency);

        }
    }
}
