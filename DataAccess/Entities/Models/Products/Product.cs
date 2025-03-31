using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.Entities.Models.OrderDetails;

namespace DataAccess.Entities.Models.Products
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        //Mapping
        public int? CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int? ProductSupplierId { get; set; }
        public ProductSupplier? ProductSupplier { get; set; }
        public virtual ICollection<ProductOrderDetail>? ProductOrderDetails { get; set; }
    }
}
