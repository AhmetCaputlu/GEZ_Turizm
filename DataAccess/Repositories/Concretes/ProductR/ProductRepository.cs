using DataAccess.Context;
using DataAccess.Entities.Models.Products;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.ProductR;

namespace DataAccess.Repositories.Concretes.Products
{
    public class ProductRepository : GenericRepository<Product>, IGenericRepository<Product>,IProductRepository
    {
        private readonly GezTurizmContext _context;

        public ProductRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Product> GetProductByName(string productName)
        {
            return _context.Products.Where(x => x.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public IQueryable<Product> GetProductByStockDesc()
        {
            return _context.Products.OrderByDescending(x => x.UnitsInStock);
        }

        public IQueryable<Product> GetProductByStocPriceDesc()
        {
            return _context.Products.OrderByDescending(x => x.UnitPrice);

        }
    }
}
