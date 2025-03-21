using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Entities.Models.Orders
{
    public class EventTicketOrder:BaseOrderModel
    {
        public virtual ICollection<EventTicketOrderDetail>? EventTicketOrderDetails { get; set; }

    }
}
