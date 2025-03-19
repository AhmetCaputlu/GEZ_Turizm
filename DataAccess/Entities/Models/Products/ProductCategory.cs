using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;

namespace DataAccess.Entities.Models.Products
{
    public class ProductCategory:BaseModel
    {
        public string CategoryName { get; set; }
        public CategoryType CategoryType { get; set; }
        public string Description { get; set; }
        //Mapping
        public virtual ICollection<Product>? Products { get; set; }
    }
}
