using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Services.BaseGenericS;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Services.Abstracts.WebUsers
{
    public interface IWebUserProfileService : IGenericService<WebUserProfile, WebUserProfileResponseDTO, WebUserProfileRequestDTO, WebUserProfileFilterModel>
    {

    }
}
