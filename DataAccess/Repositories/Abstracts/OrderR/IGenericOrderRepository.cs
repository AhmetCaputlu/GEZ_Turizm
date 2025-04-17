using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Entities.Models.Orders;

namespace DataAccess.Repositories.Abstracts.Order
{
    public interface IGenericOrderRepository : IGenericRepository<ActivityTicketOrder>
    {
        IQueryable<ActivityTicketOrder> GetOrderByNote(string note);
        IQueryable<ActivityTicketOrder> GetOrderByEmail(string email);
    }
}
