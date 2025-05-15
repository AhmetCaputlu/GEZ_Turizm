using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Regions;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Activities
{
    public class ActivityRequestDTO:BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Karakter uzunluğu 5-40 karakter olabilir!")]
        public string ActivityName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public ActivityCategory ActivityCategory { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime EndDate { get; set; }
        [StringLength(40, ErrorMessage = "Karakter uzunluğu max 180 karakter olabilir!")]
        public string? Description { get; set; }
        public virtual int? ServiceRegionId { get; set; }
    }
}
