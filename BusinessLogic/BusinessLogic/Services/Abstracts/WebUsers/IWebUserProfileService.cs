using BusinessLogic.DTOs.WebUser;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Services.Abstracts.WebUsers
{
    public interface IWebUserProfileService : IGenericService<WebUserProfile, WebUserProfileResponseDTO, WebUserProfileRequestDTO, WebUserProfileFilterModel>
    {

    }
}
