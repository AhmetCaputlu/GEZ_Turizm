using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Entities.Models.OrderDetails
{
    public class TourTicketOrderDetail:BaseOrderDetailModel
    {
        //Mapping
        public int? TourTicketId { get; set; }
        public virtual TourTicket? TourTicket { get; set; }
        public int? TourTicketOrderId { get; set; }
        public virtual TourTicketOrder? TourTicketOrder { get; set; }


    }
}
