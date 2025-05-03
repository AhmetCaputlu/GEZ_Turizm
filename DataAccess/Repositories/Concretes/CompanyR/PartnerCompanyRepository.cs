using System.ComponentModel;
using DataAccess.Context;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.Repositories.Abstracts.Company;

namespace DataAccess.Repositories.Concretes.Company
{
    public class PartnerCompanyRepository : GenericCompanyRepository<PartnerCompany>, IGenericCompanyRepository<PartnerCompany>, IPartnerCompanyRepository
    {
        private readonly GezTurizmContext _context;

        public PartnerCompanyRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<PartnerCompany> GetDynamicPartnerFilter(bool? status = null,bool? descending = null)
        {
            IQueryable<PartnerCompany> filter = _context.PartnerCompanies;
            if (status.HasValue)
            {
                filter = filter.Where(x => x.AcceptTickets == status);
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
            return filter;
        }
    }
}
