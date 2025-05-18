using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Repositories.Abstracts.Company
{
    public interface IPartnerCompanyRepository : IGenericCompanyRepository<PartnerCompany,PartnerCompanyFilterModel>
    {
        //Geliştirmeye Açık
    }
}
