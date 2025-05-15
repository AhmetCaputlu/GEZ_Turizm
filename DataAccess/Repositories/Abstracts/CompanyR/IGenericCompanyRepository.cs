using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts.Company
{
    public interface IGenericCompanyRepository<T> : IGenericRepository<T> where T : BaseCompanyModel
    {
        IQueryable<T> GetDynamicCompanyFilter(
            string? companyName = null,
            string? contactName = null,
            string? contactTitle = null,
            string? email = null,
            string? phoneNumber = null,
            string? address = null,
            bool? descending = null
            );
    }
}
