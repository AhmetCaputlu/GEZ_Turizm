using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Repositories.CompanyR
{
    public interface IPartnerCompanyRepository : IGenericCompanyRepository<PartnerCompany,PartnerCompanyFilterModel>
    {
        //Geliştirmeye Açık
    }
}
