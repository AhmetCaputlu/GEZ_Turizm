using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Employees
{
    public class EmployeeRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Karakter uzunluğu 2-30 karakter olabilir!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Karakter uzunluğu 2-30 karakter olabilir!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime BirthDate { get; set; }
        [EmailAddress(ErrorMessage = "Email formatına uygun değil!")]
        [StringLength(255, ErrorMessage = "Karakter uzunluğu max 255 karakter olabilir!")]
        public string? Email { get; set; }
        [StringLength(11, ErrorMessage = "Karakter uzunluğu max 11 karakter olabilir!")]
        public string? TCN_Passport { get; set; }
        [Range(1, 40, ErrorMessage = "Lütfen doğru bir seçim yapınız!!")]
        public int Experience { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public Department CurrentPosition { get; set; }
        public int? CountryId { get; set; }//Nav Property
    }
}
