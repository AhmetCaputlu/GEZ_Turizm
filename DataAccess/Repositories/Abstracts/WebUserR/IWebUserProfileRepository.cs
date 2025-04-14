using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Repositories.Abstracts.WebUserR
{
    public interface IWebUserProfileRepository:IGenericRepository<WebUserProfile>
    {
        IQueryable<WebUserProfile> GetUsersByName(string name);
        IQueryable<WebUserProfile> GetUsersByGender(Gender gender);
        IQueryable<WebUserProfile> GetUsersByAgeDesc();
    }
}
