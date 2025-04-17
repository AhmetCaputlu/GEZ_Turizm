using DataAccess.Context;
using DataAccess.Entities.Models.Orders;
using DataAccess.Repositories.Abstracts.Order;

namespace DataAccess.Repositories.Concretes.Order
{
    public class GenericOrderRepository: GenericRepository<ActivityTicketOrder>, IGenericOrderRepository
    {
        private readonly GezTurizmContext _context;
        public GenericOrderRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<ActivityTicketOrder> GetOrderByNote(string note)
        {
            return _context.ActivityTicketOrders.Where(x => x.Note != null &&  x.Note.ToLower().Contains(note.ToLower()));
        }

        public IQueryable<ActivityTicketOrder> GetOrderByEmail(string email)
        {
            return _context.ActivityTicketOrders.Where(x => x.WebUserEmail.ToLower().Contains(email.ToLower()));
        }
    }
}
