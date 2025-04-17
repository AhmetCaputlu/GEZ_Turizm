using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Repositories.Abstracts.OrderDetail;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.OrderDetail
{
    public class GenericOrderDetailRepository : GenericRepository<ActivityTicketOrderDetail>, IGenericOrderDetailRepository
    {
        private readonly GezTurizmContext _context;
        public GenericOrderDetailRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<ActivityTicketOrderDetail> GetDetailByUnitPriceDesc()
        {
            return _context.ActivityTicketOrderDetails.OrderByDescending(x => x.UnitPrice);
        }
        public IQueryable<ActivityTicketOrderDetail> GetDetailByQuantityDesc()
        {
            return _context.ActivityTicketOrderDetails.OrderByDescending(x => x.Quantity);
        }
        public IQueryable<ActivityTicketOrderDetail> GetTotalCostRange(decimal low, decimal high)
        {
            return _context.ActivityTicketOrderDetails.Where(x => x.UnitPrice <= high && x.UnitPrice >= low);
        }
    }
}
