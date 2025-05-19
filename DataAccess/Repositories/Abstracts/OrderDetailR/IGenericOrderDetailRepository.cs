using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.OrderDetails;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Repositories.Abstracts.OrderDetail
{
    public interface IGenericOrderDetailRepository : IGenericRepository<ActivityTicketOrderDetail, OrderDetailFilterModel>
    {

    }
}
