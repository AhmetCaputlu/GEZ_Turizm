using DataAccess.Entities.Models.Regions;

namespace BusinessLogic.DTOs.ResponseDTOs.Abstracts
{
    public class BaseActivityResponseDTO:BaseResponseDTO
    {
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public ServiceRegion? ServiceRegion { get; set; }
    }
}
