using DataAccess.Configurations.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Entities.Models.Orders;

namespace DataAccess.Entities.Models.Tickets
{
    public class TourTicket:BaseTicketModel
    {
        //Mapping
        public int? TourId { get; set; }
        public virtual Tour? Tour { get; set; }
        public virtual ICollection<TourTicketOrderDetail>? TourTicketOrderDetails { get; set; }
    }
}
