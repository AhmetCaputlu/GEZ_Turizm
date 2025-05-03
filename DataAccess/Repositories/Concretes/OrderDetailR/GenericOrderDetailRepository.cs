using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Repositories.Abstracts.OrderDetail;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.OrderDetail
{
    public class GenericOrderDetailRepository : GenericRepository<ActivityTicketOrderDetail>, IGenericOrderDetailRepository
    {
        private readonly GezTurizmContext _context;
        public GenericOrderDetailRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<ActivityTicketOrderDetail> GetDynamicOrderDetailFilter(decimal? low = null, decimal? high = null, bool? descendingId = null, bool? descendingPrice = null)
        {
            IQueryable<ActivityTicketOrderDetail> filter = _context.ActivityTicketOrderDetails;
            if (low.HasValue && high.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) >= low.Value && x.TotalCost <= high.Value);
            }
            else if (low.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) >= low.Value);
            }
            else if (high.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) <= high.Value);
            }
            if (descendingId == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            else if (descendingPrice == true)
            {
                filter = filter.OrderByDescending(x => x.TotalCost);
            }
            return filter;
        }
    }
}
