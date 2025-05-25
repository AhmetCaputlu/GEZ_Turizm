using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseCompanyRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(90, MinimumLength = 15, ErrorMessage = "Karakter uzunluğu 5-90 karakter olabilir!")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(40, ErrorMessage = "Karakter uzunluğu max 40 karakter olabilir!")]
        public string ContactName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(50, MinimumLength = 15, ErrorMessage = "Karakter uzunluğu max 50 karakter olabilir!")]
        public string ContactTitle { get; set; }
        [EmailAddress(ErrorMessage = "Email formatına uygun değil!")]
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(255, ErrorMessage = "Karakter uzunluğu max 255 karakter olabilir!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "Lütfen alan kodu olmadan tuşlayınız!!")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(255, ErrorMessage = "Karakter uzunluğu max 255 karakter olabilir!")]
        public string Address { get; set; }
    }
}
