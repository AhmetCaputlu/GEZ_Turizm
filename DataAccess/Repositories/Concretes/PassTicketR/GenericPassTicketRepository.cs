using System.Linq;
using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.PassTickets;
using DataAccess.Entities.Models.PassTickets;
using DataAccess.Repositories.Abstracts.PassTicket;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.PassTicket
{
    public class GenericPassTicketRepository : GenericRepository<ActivityPassTicket, PassTicketFilterModel>, IGenericPassTicketRepository
    {
        private readonly GezTurizmContext _context;
        public GenericPassTicketRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<ActivityPassTicket> GetDynamicFilteredEntities(PassTicketFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.MinPrice.HasValue && filterModel.MaxPrice.HasValue)
            {
                filter = filter.Where(
                    x => x.TotalCostwithCommission > filterModel.MinPrice && x.TotalCostwithCommission < filterModel.MaxPrice);
            }
            else if (filterModel.MinPrice.HasValue)
            {
                filter = filter.Where(x => x.TotalCostwithCommission > filterModel.MinPrice);
            }
            else if (!filterModel.MaxPrice.HasValue)
            {
                filter = filter.Where(x => x.TotalCostwithCommission < filterModel.MaxPrice);
            }
            if (filterModel.Descending != true && filterModel.DescendingByTotalCost == true)
            {
                filter = filter.OrderByDescending(x => x.TotalCostwithCommission);
            }
            else if (filterModel.Descending != true && filterModel.DescendingByCommissionRate == true)
            {
                filter = filter.OrderByDescending(x => x.CommissionRate);
            }

            return filter;
        }
    }
}
