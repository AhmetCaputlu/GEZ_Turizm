using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Entities.Models.Tickets
{
    public class ActivityTicket : BaseModel
    {
        public string TicketHolderName { get; set; }
        public string SeatNumber { get; set; }
        public string DepartureAdress { get; set; }
        public string DestinationAdress { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public decimal Price { get; set; }
        public byte? DiscountRate { get; set; }//VIP Users  
        public decimal? NetCost { get { return ((100 - DiscountRate) * Price) / 100; } set { } }
        public Currency Currency { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        //Mapping
        public int? ActivityId { get; set; }
        public virtual Activity? Activity { get; set; }
        public virtual ICollection<ActivityTicketOrderDetail>? ActivityTicketOrderDetails { get; set; }

    }
}
