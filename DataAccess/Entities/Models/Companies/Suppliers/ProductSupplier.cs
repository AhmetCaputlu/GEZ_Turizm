using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Products;

namespace DataAccess.Entities.Models.Companies.Suppliers
{
    public class ProductSupplier:BaseCompanyModel
    {
        //Mapping
        public virtual ICollection<Product> Products { get; set; }

    }
}
