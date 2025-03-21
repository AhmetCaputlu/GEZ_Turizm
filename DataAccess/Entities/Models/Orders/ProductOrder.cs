using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Entities.Models.Orders
{
    public class ProductOrder:BaseOrderModel
    {
        public virtual ICollection<ProductOrderDetail>? ProductOrderDetails { get; set; }

    }
}
