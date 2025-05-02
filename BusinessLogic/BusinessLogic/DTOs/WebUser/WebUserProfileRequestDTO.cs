using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.WebUser
{
    public class WebUserProfileRequestDTO:BaseRequestModelDTO
    {
        [Required(ErrorMessage ="Bu alan zorunludur!!")]
        [StringLength(30,MinimumLength =2,ErrorMessage ="2-30 karakter arasında bir değer girin!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "2-30 karakter arasında bir değer girin!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        //todo:İş mantığında kullanıcı yaşı belirli bir yaşın üzerindeyse hata döndür!!
        public DateTime BirthDate { get; set; }
        [MaxLength(200,ErrorMessage ="Adres uzunluğu max 200 karakterdir!!")]
        public string? Address { get; set; }
    }
}
