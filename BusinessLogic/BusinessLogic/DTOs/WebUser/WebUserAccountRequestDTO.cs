using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.WebUser
{
    public class WebUserAccountRequestDTO:BaseRequestModelDTO
    {
        [Required(ErrorMessage ="Bu alan zorunludur!!")]
        [StringLength(32,MinimumLength =24,ErrorMessage ="Karakter uzunluğu 24-32 karakter olabilir!")]
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage ="Email formatına uygun değil!")]
        [StringLength(32, MinimumLength = 24, ErrorMessage = "Max 120 karakter ve email formatında olmalıdır!!")]
        [Required(ErrorMessage ="Bu alan zorunludur!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(11,MinimumLength =10,ErrorMessage ="Lütfen alan kodu olmadan tuşlayınız!!")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public int? CountryId { get; set; }//Nav property
    }
}
