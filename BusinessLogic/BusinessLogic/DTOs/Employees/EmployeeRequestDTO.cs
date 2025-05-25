using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Employees
{
    public class EmployeeRequestDTO : BaseEmployeeRequestDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public Department CurrentPosition { get; set; }
        public int? CountryId { get; set; }//Nav Property
    }
}
