using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Entities.Models.Orders
{
    public class TourTicketOrder:BaseOrderModel
    {
        public virtual ICollection<TourTicketOrderDetail>? TourTicketOrderDetails { get; set; }
    }
}
