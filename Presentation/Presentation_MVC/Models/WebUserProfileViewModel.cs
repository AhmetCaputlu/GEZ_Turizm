using BusinessLogic.DTOs.WebUser;
using DataAccess.Entities.FilterModels.WebUsers;

namespace Presentation_MVC.Models
{
    public class WebUserProfileViewModel
    {
        public WebUserProfileFilterModel Filter { get; set; } = new();
        public IEnumerable<WebUserProfileResponseDTO> List { get; set; } = new List<WebUserProfileResponseDTO>();
    }
}
