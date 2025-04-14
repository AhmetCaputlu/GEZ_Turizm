using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Products;

namespace DataAccess.Repositories.Abstracts.ProductR
{
    public interface IProductCategoryRepository:IGenericRepository<ProductCategory>
    {
        IQueryable<ProductCategory> GetProductCategoriesByCategoryType(CategoryType categoryType);
    }
}
