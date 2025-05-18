using BusinessLogic.DTOs.WebUser;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Services.Abstracts.WebUsers
{
    public interface IWebUserProfileService : IService<WebUserProfile, WebUserProfileResponseDTO, WebUserProfileRequestDTO>
    {
        IQueryable<WebUserProfileResponseDTO> GetDynamicUserProfileFilter(string? name = null, Gender? gender = null, bool? descendingAge = null, bool? descending = null);
    }
}
