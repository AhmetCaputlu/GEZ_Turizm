using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.SignIn_SignUpDTOs
{
    public class WebUserAccountRegisterDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public string PasswordAgain { get; set; }
    }
}
