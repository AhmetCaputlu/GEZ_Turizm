using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Products;

namespace DataAccess.Entities.Models.Orders
{
    public class ProductOrder:BaseOrderModel
    {
        //Mapping

        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
