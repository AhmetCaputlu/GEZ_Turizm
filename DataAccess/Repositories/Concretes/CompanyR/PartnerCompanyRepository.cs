using DataAccess.Context;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Repositories.Abstracts.Company;

namespace DataAccess.Repositories.Concretes.Company
{
    public class PartnerCompanyRepository : GenericCompanyRepository<PartnerCompany, PartnerCompanyFilterModel>, IPartnerCompanyRepository
    {
        private readonly GezTurizmContext _context;

        public PartnerCompanyRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Partner Company için oluşturulmuş spesifik sorgu metodu
        /// </summary>
        /// <param name="filterModel"></param>
        /// <returns></returns>
        public override IQueryable<PartnerCompany> GetDynamicFilteredEntities(PartnerCompanyFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.AcceptTickets.HasValue)
            {
                filter = filter.Where(x => x.AcceptTickets == filterModel.AcceptTickets);
            }
            return filter;
        }
    }
}
