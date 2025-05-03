using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Repositories.Abstracts.OrderDetail
{
    public interface IGenericOrderDetailRepository : IGenericRepository<ActivityTicketOrderDetail>
    {
        IQueryable<ActivityTicketOrderDetail> GetDynamicOrderDetailFilter(decimal? low = null, decimal? high = null, bool? descendingId = null, bool? descendingPrice = null);
    }
}
