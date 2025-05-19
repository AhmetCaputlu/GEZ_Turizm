using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Repositories.Abstracts.Ticket;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DataAccess.Repositories.Concretes.Ticket
{
    public class TicketRepository : GenericRepository<ActivityTicket, TicketFilterModel>, ITicketRepository
    {
        private readonly GezTurizmContext _context;
        public TicketRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<ActivityTicket> GetDynamicFilteredEntities(TicketFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (!string.IsNullOrEmpty(filterModel.TicketName))
            {
                filter = filter.Where(x => x.TicketHolderName.ToLower().Contains(filterModel.TicketName.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.SeatNumber))
            {
                filter = filter.Where(x => x.SeatNumber.ToLower().Contains(filterModel.SeatNumber.ToLower()));
            }
            if (filterModel.DepartureDate.HasValue)
            {
                filter = filter.Where(x => x.DepartureDate.Date == filterModel.DepartureDate.Value.Date);
            }
            if (filterModel.ArrivalDate.HasValue)
            {
                filter = filter.Where(x => x.ArrivalDate.Date == filterModel.ArrivalDate.Value.Date);
            }
            if (filterModel.MinCost.HasValue && filterModel.MaxCost.HasValue)
            {
                filter = filter.Where(x => x.NetCost > filterModel.MinCost.Value && x.NetCost < filterModel.MaxCost.Value);
            }
            else if (filterModel.MinCost.HasValue)
            {
                filter = filter.Where(x => x.NetCost >= filterModel.MinCost.Value);
            }
            else if (filterModel.MaxCost.HasValue)
            {
                filter = filter.Where(x => x.NetCost <= filterModel.MaxCost.Value);
            }
            if (filterModel.PaymentStatus.HasValue)
            {
                filter = filter.Where(x => x.PaymentStatus == filterModel.PaymentStatus.Value);
            }
            if (filterModel.Currency.HasValue)
            {
                filter = filter.Where(x => x.Currency == filterModel.Currency.Value);
            }
            if (filterModel.Descending != true && filterModel.DescendingByTotalCost == true)
            {
                filter = filter.OrderByDescending(x => x.NetCost);
            }

            return filter;
        }
    }
}
