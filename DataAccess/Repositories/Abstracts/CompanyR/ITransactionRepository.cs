using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Repositories.Abstracts.CompanyR
{
    public interface ITransactionRepository : IGenericRepository<PartnerCompanyTransaction, TransactionFilterModel>
    {
        //Geliştirmeye açık
    }
}
