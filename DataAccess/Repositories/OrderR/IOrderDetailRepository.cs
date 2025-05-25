using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Orders;
using DataAccess.Entities.Models.Orders;

namespace DataAccess.Repositories.OrderR
{
    public interface IOrderDetailRepository : IGenericRepository<ActivityTicketOrderDetail, OrderDetailFilterModel>
    {

    }
}
