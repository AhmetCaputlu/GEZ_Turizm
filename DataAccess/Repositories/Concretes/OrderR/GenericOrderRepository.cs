using DataAccess.Context;
using DataAccess.Entities.Models.Orders;
using DataAccess.Repositories.Abstracts.Order;

namespace DataAccess.Repositories.Concretes.Order
{
    public class GenericOrderRepository : GenericRepository<ActivityTicketOrder>, IGenericOrderRepository
    {
        private readonly GezTurizmContext _context;
        public GenericOrderRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<ActivityTicketOrder> GetDynamicOrderFilter(string? note = null, string? email = null, bool? descending = null)
        {
            IQueryable<ActivityTicketOrder> filter = _context.ActivityTicketOrders;
            if (!string.IsNullOrEmpty(note))
            {
                filter = filter.Where(x => (x.Note ?? "").ToLower().Contains(note.ToLower()));
            }
            if (!string.IsNullOrEmpty(email))
            {
                filter = filter.Where(x => (x.WebUserEmail ?? "").ToLower().Contains(email.ToLower()));
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
