using DataAccess.Entities.Enums;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseTicketModel : BaseModel
    {
        public string TicketName { get; set; }
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
    }
}
