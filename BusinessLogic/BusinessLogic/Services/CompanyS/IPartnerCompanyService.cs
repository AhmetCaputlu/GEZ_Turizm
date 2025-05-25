using BusinessLogic.DTOs.Companies.PartnerCompanies;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace BusinessLogic.Services.CompanyS
{
    public interface IPartnerCompanyService : IGenericCompanyService<PartnerCompany, PartnerCompanyResponseDTO, PartnerCompanyRequestDTO, PartnerCompanyFilterModel>
    {

    }
}
