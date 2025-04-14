using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Products;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.ProductR;

namespace DataAccess.Repositories.Concretes.ProductR
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IGenericRepository<ProductCategory>, IProductCategoryRepository
    {
        private readonly GezTurizmContext _context;

        public ProductCategoryRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<ProductCategory> GetProductCategoriesByCategoryType(CategoryType categoryType)
        {
            return _context.ProductCategories.Where(x => x.CategoryType == categoryType);
        }
    }
}
