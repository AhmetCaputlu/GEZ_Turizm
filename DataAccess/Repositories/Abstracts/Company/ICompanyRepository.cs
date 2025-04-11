using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts.Company
{
    public interface ICompanyRepository<T> : IRepository<T> where T : BaseCompanyModel
    {
        IQueryable<T> SearchByCompanyName(string companyName);
        IQueryable<T> SearchByContactName(string contactName);
        IQueryable<T> SearchByContactTitle(string contactTitle);
        IQueryable<T> SearchByEmail(string email);
        IQueryable<T> SearchByPhoneNumber(string phoneNumber);
        IQueryable<T> SearchByAdress(string address);
    }
}
