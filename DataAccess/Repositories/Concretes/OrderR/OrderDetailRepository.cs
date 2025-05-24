using DataAccess.Context;
using DataAccess.Entities.FilterModels.Orders;
using DataAccess.Entities.Models.Orders;
using DataAccess.Repositories.Abstracts.OrderR;

namespace DataAccess.Repositories.Concretes.OrderR
{
    public class OrderDetailRepository : GenericRepository<ActivityTicketOrderDetail, OrderDetailFilterModel>, IOrderDetailRepository
    {
        private readonly GezTurizmContext _context;
        public OrderDetailRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<ActivityTicketOrderDetail> GetDynamicFilteredEntities(OrderDetailFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.MinPrice.HasValue && filterModel.MaxPrice.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) >= filterModel.MinPrice.Value && x.TotalCost <= filterModel.MaxPrice.Value);
            }
            else if (filterModel.MinPrice.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) >= filterModel.MinPrice.Value);
            }
            else if (filterModel.MaxPrice.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) <= filterModel.MaxPrice.Value);
            }
            if (filterModel.Descending != true && filterModel.DescendingByPrice == true)
            {
                filter = filter.OrderByDescending(x => x.TotalCost);
            }
            return filter;
        }
    }
}
