using BusinessLogic.DTOs.Companies.PartnerCompanies;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace BusinessLogic.Services.CompanyS
{
    public interface ITransactionService : IGenericService<PartnerCompanyTransaction, TransactionResponseDTO, TransactionRequestDTO, TransactionFilterModel>
    {

    }
}
