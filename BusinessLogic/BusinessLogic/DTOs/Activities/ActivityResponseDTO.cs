using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Regions;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Regions;

namespace BusinessLogic.DTOs.Activities
{
    public class ActivityResponseDTO:BaseResponseModelDTO
    {
        public string ActivityName { get; set; }
        public ActivityCategory ActivityCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public virtual RegionResponseDTO? ServiceRegionResponseDTO { get; set; }
    }
}
