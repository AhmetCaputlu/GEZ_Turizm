using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Companies;

namespace BusinessLogic.Services.CompanyS
{
    public interface IGenericCompanyService<TEntity, TResponse, TRequest, TFilterEntity> :
        IGenericService<TEntity, TResponse, TRequest, TFilterEntity>
        where TEntity : BaseCompanyModel where TResponse : BaseCompanyResponseDTO
        where TRequest : BaseCompanyRequestDTO where TFilterEntity : BaseCompanyFilterModel, new()
    {

    }
}
