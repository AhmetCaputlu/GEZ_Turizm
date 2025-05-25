using BusinessLogic.DTOs.Orders;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Orders;
using DataAccess.Entities.Models.Orders;

namespace BusinessLogic.Services.OrderS
{
    public interface IOrderService : IGenericService<ActivityTicketOrder, OrderResponseDTO, OrderRequestDTO, OrderFilterModel>
    {

    }
}
