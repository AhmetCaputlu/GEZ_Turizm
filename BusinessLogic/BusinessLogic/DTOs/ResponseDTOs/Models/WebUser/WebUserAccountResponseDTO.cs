using BusinessLogic.DTOs.ResponseDTOs.Abstracts;

namespace BusinessLogic.DTOs.ResponseDTOs.Models.WebUser
{
    public class WebUserAccountResponseDTO : BaseResponseDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
    }
}
