using DataAccess.Context;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Repositories.Abstracts.CompanyR;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.CompanyR
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
                filter.Where(x => x.PartnerCompanyId == filterModel.PartnerCompanyId);
            }
            if (filterModel.TransactionType.HasValue)
            {
                filter.Where(x => x.Type == filterModel.TransactionType);
            }
            if (filterModel.FirstTotalCost.HasValue && filterModel.LastTotalCost.HasValue)
            {
                filter.Where(x => x.TotalCost >= filterModel.FirstTotalCost && x.TotalCost <= filterModel.LastTotalCost);
            }
            else if (filterModel.FirstTotalCost.HasValue)
            {
                filter.Where(x => x.TotalCost >= filterModel.FirstTotalCost);
            }
            else if (filterModel.LastTotalCost.HasValue)
            {
                filter.Where(x => x.TotalCost <= filterModel.LastTotalCost);
            }
            return filter;
        }
    }
}
