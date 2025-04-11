using BusinessLogic.DTOs.BasicDTOs.Abstracts;

namespace BusinessLogic.DTOs.BasicDTOs.Models.WebUser
{
    public class WebUserAccountDTO : BaseModelDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public CountryDTO Country { get; set; }
        public WebUserProfileDTO WebUserProfile { get; set; }
    }
}
