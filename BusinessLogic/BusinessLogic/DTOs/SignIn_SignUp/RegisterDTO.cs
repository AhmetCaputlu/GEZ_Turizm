using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.SignIn_SignUp
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur ! !!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur ! !!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur ! !!")]
        public string Password { get; set; }
    }
}
