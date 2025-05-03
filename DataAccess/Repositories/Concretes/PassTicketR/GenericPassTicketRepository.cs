using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.Repositories.Abstracts.PassTicket;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.PassTicket
{
    public class GenericPassTicketRepository : GenericRepository<ActivityPassTicket>, IGenericPassTicketRepository
    {
        private readonly GezTurizmContext _context;
        public GenericPassTicketRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<ActivityPassTicket> GetDynamicPassTicketFilter(bool? descendingTotalCost = null, bool? descending = null)
        {
            IQueryable<ActivityPassTicket> filter = _context.ActivityPassTickets;
            if (descendingTotalCost == true)
            {
                filter = filter.OrderByDescending(x => x.TotalCostwithCommission);
            }
            else if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
