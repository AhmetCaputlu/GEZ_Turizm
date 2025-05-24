using DataAccess.Context;
using DataAccess.Entities.FilterModels.Tickets;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Repositories.Abstracts.TicketR;

namespace DataAccess.Repositories.Concretes.TicketR
{
    public class PassTicketRepository : GenericRepository<ActivityPassTicket, PassTicketFilterModel>, IPassTicketRepository
    {
        private readonly GezTurizmContext _context;
        public PassTicketRepository(GezTurizmContext context) : base(context)
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
