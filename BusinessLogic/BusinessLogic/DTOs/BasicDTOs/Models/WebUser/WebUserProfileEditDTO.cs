using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.BasicDTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.BasicDTOs.Models.WebUser
{
    public class WebUserProfileEditDTO : BaseModelDTO
    {
        [Required(ErrorMessage ="Bu alanın doldurulması zorunludur !")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur !")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur !")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Bu alanın doldurulması zorunludur !")]
        public DateTime BirthDate { get; set; }
        public byte? Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age))
                {
                    age--;
                }
                return (byte?)age;
            }
            set { }
        }
        public string? Address { get; set; }
        public string? PhotoPath { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? TCN_Passport { get; set; }
    }
}
