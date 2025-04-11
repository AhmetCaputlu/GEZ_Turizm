using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.SignIn_SignUp
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="Eksik veya hatalı bilgi giriş bilgileri !!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Eksik veya hatalı bilgi giriş bilgileri !!")]
        public string Password { get; set; }//todo:Bcrypt içerisindeki verify metoduyla kontrol edilecek
    }
}
