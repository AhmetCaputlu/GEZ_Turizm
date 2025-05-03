using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Repositories.Abstracts.WebUserR
{
    public interface IWebUserProfileRepository : IGenericRepository<WebUserProfile>
    {
        IQueryable<WebUserProfile> GetDynamicUserProfileFilter(string? name = null, Gender? gender = null, bool? descendingAge = null, bool? descending = null);
    }
}