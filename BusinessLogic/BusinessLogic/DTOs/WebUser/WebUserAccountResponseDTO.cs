using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.WebUser
{
    public class WebUserAccountResponseDTO:BaseResponseModelDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public WebUserProfileResponseDTO? WebUserProfileResponseDTO { get; set; }
    }
}
