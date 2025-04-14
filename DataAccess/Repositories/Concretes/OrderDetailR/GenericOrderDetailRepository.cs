using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.OrderDetail;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.OrderDetail
{
    public class GenericOrderDetailRepository<T> : GenericRepository<T>, IGenericOrderDetailRepository<T> where T : BaseOrderDetailModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericOrderDetailRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> GetDetailByUnitPriceDesc()
        {
            return _dbset.OrderByDescending(x => x.UnitPrice);
        }
        public IQueryable<T> GetDetailByQuantityDesc()
        {
            return _dbset.OrderByDescending(x => x.Quantity);
        }
        public IQueryable<T> GetTotalCostRange(decimal low, decimal high)
        {
            return _dbset.Where(x => x.UnitPrice <= high && x.UnitPrice >= low);
        }
    }
}
