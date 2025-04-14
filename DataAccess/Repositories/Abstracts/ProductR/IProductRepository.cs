using DataAccess.Entities.Models.Products;

namespace DataAccess.Repositories.Abstracts.ProductR
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        IQueryable<Product> GetProductByName(string productName);
        IQueryable<Product> GetProductByStockDesc();
        IQueryable<Product> GetProductByStocPriceDesc();
    }
}
