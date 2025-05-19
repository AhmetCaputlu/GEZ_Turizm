using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Tickets;

namespace BusinessLogic.DTOs.Orders
{
    public class OrderDetailResponseDTO : BaseResponseModelDTO
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalCost { get { return UnitPrice * Quantity * (1 - Discount); } }
        public TicketResponseDTO? ActivityTicketResponseDTO { get; set; }
        public OrderResponseDTO? OrderResponseDTO { get; set; }
    }
}
