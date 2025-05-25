using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Companies;

namespace DataAccess.Repositories.CompanyR
{
    public interface IGenericCompanyRepository<TEntity, TFilterEntity> : IGenericRepository<TEntity, TFilterEntity> where TEntity : BaseCompanyModel where TFilterEntity : BaseCompanyFilterModel
    {
        //Geliştirmeye açık
    }
}
