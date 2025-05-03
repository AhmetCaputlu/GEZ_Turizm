using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Repositories.Abstracts.Company
{
    public interface IPartnerCompanyRepository : IGenericCompanyRepository<PartnerCompany>
    {
        IQueryable<PartnerCompany> GetDynamicPartnerFilter(bool? status = null,bool? descending = null);
    }
}
