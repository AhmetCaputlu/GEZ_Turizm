using DataAccess.Context;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.CompanyR
{
    public class TransactionRepository : GenericRepository<PartnerCompanyTransaction, TransactionFilterModel>, ITransactionRepository
    {
        private readonly GezTurizmContext _context;
        public TransactionRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        /// <summary>
        /// Şirket pas bileti işlemlerini filtrelemek için ezilmiş sorgu metodu
        /// </summary>
        /// <param name="filterModel"></param>
        /// <returns></returns>
        public override IQueryable<PartnerCompanyTransaction> GetDynamicFilteredEntities(TransactionFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.PartnerCompanyId.HasValue)
            {
                filter = filter.Where(x => x.PartnerCompanyId == filterModel.PartnerCompanyId);
            }
            if (filterModel.TransactionType.HasValue)
            {
                filter = filter.Where(x => x.Type == filterModel.TransactionType);
            }
            if (filterModel.FirstTotalCost.HasValue && filterModel.LastTotalCost.HasValue)
            {
                filter = filter.Where(x => x.TotalCost >= filterModel.FirstTotalCost && x.TotalCost <= filterModel.LastTotalCost);
            }
            else if (filterModel.FirstTotalCost.HasValue)
            {
                filter = filter.Where(x => x.TotalCost >= filterModel.FirstTotalCost);
            }
            else if (filterModel.LastTotalCost.HasValue)
            {
                filter = filter.Where(x => x.TotalCost <= filterModel.LastTotalCost);
            }
            if (filterModel.Descending != true && filterModel.DescendingByTotalCost == true)
            {
                filter = filter.OrderByDescending(x => x.TotalCost);
            }
            return filter;
        }
    }
}
