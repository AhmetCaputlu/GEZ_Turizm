using DataAccess.Context;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Repositories.Abstracts.Company;
using NetTopologySuite.IO;

namespace DataAccess.Repositories.Concretes.Company
{
    public class PartnerCompanyRepository : GenericCompanyRepository<PartnerCompany>, IGenericCompanyRepository<PartnerCompany>, IPartnerCompanyRepository
    {
        private readonly GezTurizmContext _context;

        public PartnerCompanyRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<PartnerCompany> GetPartnersByBalanceDesc()
        {
            return _context.PartnerCompanies.OrderByDescending(x => x.Balance);
        }

        public IQueryable<PartnerCompany> GetPartnersForTradingStatus(bool status)
        {
            return _context.PartnerCompanies.Where(x => x.AcceptTickets == status);
        }
    }
}
