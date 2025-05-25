using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Repositories.WebUserR
{
    public interface IWebUserProfileRepository : IGenericRepository<WebUserProfile,WebUserProfileFilterModel>
    {
        
    }
}