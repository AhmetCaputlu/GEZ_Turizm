using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Repositories.Abstracts.OrderDetail
{
    public interface IGenericOrderDetailRepository : IGenericRepository<ActivityTicketOrderDetail>
    {
        IQueryable<ActivityTicketOrderDetail> GetDetailByUnitPriceDesc();
        IQueryable<ActivityTicketOrderDetail> GetDetailByQuantityDesc();
        IQueryable<ActivityTicketOrderDetail> GetTotalCostRange(decimal low, decimal high);
    }
}
