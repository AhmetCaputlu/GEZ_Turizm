using DataAccess.Entities.FilterModels.Orders;
using DataAccess.Entities.Models.Orders;

namespace DataAccess.Repositories.Abstracts.Order
{
    public interface IGenericOrderRepository : IGenericRepository<ActivityTicketOrder, OrderFilterModel>
    {

    }
}
