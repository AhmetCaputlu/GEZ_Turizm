using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Repositories.Abstracts.WebUserR
{
    public interface IWebUserProfileRepository : IGenericRepository<WebUserProfile,WebUserProfileFilterModel>
    {
        
    }
}