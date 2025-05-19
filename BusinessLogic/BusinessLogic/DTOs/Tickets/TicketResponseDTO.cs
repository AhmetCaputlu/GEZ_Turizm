using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Activities;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Tickets
{
    public class TicketResponseDTO : BaseResponseModelDTO
    {
        public string TicketHolderName { get; set; }
        public string SeatNumber { get; set; }
        public string DepartureAdress { get; set; }
        public DateTime DepartureDate { get; set; }
        public Currency Currency { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public decimal Price { get; set; }
        public byte? DiscountRate { get; set; }//VIP Users  
        public decimal? NetCost { get { return ((100 - DiscountRate) * Price) / 100; } }
        public ActivityResponseDTO? ActivityResponseDTO { get; set; }
    }
}
