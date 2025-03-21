using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Entities.Models.OrderDetails
{
    public class EventTicketOrderDetail:BaseOrderDetailModel
    {
        //Mapping
        public int? EventTicketId { get; set; }
        public virtual EventTicket? EventTicket { get; set; }
        public int? EventTicketOrderId { get; set; }
        public virtual EventTicketOrder? EventTicketOrder { get; set; }
    }
}
