using DataAccess.Context;
using DataAccess.Entities.FilterModels.Orders;
using DataAccess.Entities.Models.Orders;

namespace DataAccess.Repositories.OrderR
{
    public class OrderRepository : GenericRepository<ActivityTicketOrder, OrderFilterModel>, IOrderRepository
    {
        private readonly GezTurizmContext _context;
        public OrderRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<ActivityTicketOrder> GetDynamicFilteredEntities(OrderFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (!string.IsNullOrEmpty(filterModel.Note))
            {
                filter = filter.Where(x => (x.Note ?? "").ToLower().Contains(filterModel.Note.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.Email))
            {
                filter = filter.Where(x => (x.WebUserEmail ?? "").ToLower().Contains(filterModel.Email.ToLower()));
            }

            return filter;
        }
    }
}
