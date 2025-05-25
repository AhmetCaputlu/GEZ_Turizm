using DataAccess.Entities.FilterModels.Orders;
using DataAccess.Entities.Models.Orders;

namespace DataAccess.Repositories.OrderR
{
    public interface IOrderRepository : IGenericRepository<ActivityTicketOrder, OrderFilterModel>
    {

    }
}
