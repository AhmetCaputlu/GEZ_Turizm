using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Orders;
using BusinessLogic.DTOs.Tickets;

namespace BusinessLogic.DTOs.OrderDetails
{
    public class OrderDetailResponseDTO : BaseResponseModelDTO
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TotalCost { get { return (UnitPrice * Quantity) * (1 - Discount); } }
        public ActivityTicketResponseDTO? ActivityTicketResponseDTO { get; set; }
        public OrderResponseDTO? OrderResponseDTO { get; set; }
    }
}
