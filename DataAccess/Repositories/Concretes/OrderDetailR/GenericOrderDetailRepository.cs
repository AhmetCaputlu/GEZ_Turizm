using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.OrderDetails;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.Repositories.Abstracts.OrderDetail;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.OrderDetail
{
    public class GenericOrderDetailRepository : GenericRepository<ActivityTicketOrderDetail, OrderDetailFilterModel>, IGenericOrderDetailRepository
    {
        private readonly GezTurizmContext _context;
        public GenericOrderDetailRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<ActivityTicketOrderDetail> GetDynamicFilteredEntities(OrderDetailFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.MinPrice.HasValue && filterModel.MaxPrice.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) >= filterModel.MinPrice.Value && x.TotalCost <= filterModel.MaxPrice.Value);
            }
            else if (filterModel.MinPrice.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) >= filterModel.MinPrice.Value);
            }
            else if (filterModel.MaxPrice.HasValue)
            {
                filter = filter.Where(x => (x.TotalCost ?? 0) <= filterModel.MaxPrice.Value);
            }
            if (filterModel.Descending != true && filterModel.DescendingByPrice == true)
            {
                filter = filter.OrderByDescending(x => x.TotalCost);
            }
            return filter;
        }
    }
}
