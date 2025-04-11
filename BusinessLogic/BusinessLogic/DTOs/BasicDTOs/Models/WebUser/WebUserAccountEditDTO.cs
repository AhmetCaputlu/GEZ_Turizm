using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.BasicDTOs.Abstracts;

namespace BusinessLogic.DTOs.BasicDTOs.Models.WebUser
{
    public class WebUserAccountEditDTO : BaseModelDTO
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        [StringLength(120, MinimumLength = 24, ErrorMessage = "Kullanıcı adı min 24,max 120 karakter olabilir!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [StringLength(120, ErrorMessage = "Kullanıcı adı max 120 karakter olabilir!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sadece telefon numaranızı tuşlayın(10 hane)")]
        [StringLength(15, ErrorMessage = "Lütfen geçerli bir telefon numarası girin !")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Ülke seçimini yapın!")]
        public CountryDTO Country { get; set; }
        public WebUserProfileDTO? WebUserProfile { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [StringLength(34, MinimumLength = 16, ErrorMessage = "Şifre min 16,max 34 karakter olabilir!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrarı boş geçilemez!")]
        [StringLength(34, MinimumLength = 16, ErrorMessage = "Şifre min 16,max 34 karakter olabilir!")]
        public string PasswordAgain { get; set; }
    }
}
