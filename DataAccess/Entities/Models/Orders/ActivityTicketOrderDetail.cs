using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Entities.Models.Orders
{
    public class ActivityTicketOrderDetail : BaseModel
    {
        public decimal UnitPrice { get; set; }//Bu biletler ve ürünlerden NetCost Property'sini alacak
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }//Vip'den bağımsız tanımlanan indirim.
        public decimal? TotalCost { get { return UnitPrice * Quantity * (1 - Discount); } set { } }
        //Mapping
        public int? ActivityTicketId { get; set; }
        public virtual ActivityTicket? ActivityTicket { get; set; }
        public int? ActivityTicketOrderId { get; set; }
        public virtual ActivityTicketOrder? ActivityTicketOrder { get; set; }
    }
}
