using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Entities.Models.Tickets
{
    public class EventTicket:BaseTicketModel
    {
        //Mapping
        public int? EventId { get; set; }
        public virtual Event? Event { get; set; }
        public virtual ICollection<EventTicketOrderDetail>? EventTicketOrderDetails { get; set; }

    }
}
