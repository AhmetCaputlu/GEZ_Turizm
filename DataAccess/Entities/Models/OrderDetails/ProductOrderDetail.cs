using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Orders;
using DataAccess.Entities.Models.Products;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Entities.Models.OrderDetails
{
    public class ProductOrderDetail:BaseOrderDetailModel
    {
        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int? ProductOrderId { get; set; }
        public virtual ProductOrder? ProductOrder { get; set; }
    }
}
