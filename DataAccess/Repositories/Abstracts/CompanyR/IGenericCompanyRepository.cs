using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Companies;

namespace DataAccess.Repositories.Abstracts.Company
{
    public interface IGenericCompanyRepository<TEntity, TFilteredEntity> : IGenericRepository<TEntity, TFilteredEntity> where TEntity : BaseCompanyModel where TFilteredEntity : BaseCompanyFilterModel
    {
        //Geliştirmeye açık
    }
}
