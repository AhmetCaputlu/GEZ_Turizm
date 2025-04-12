namespace BusinessLogic.DTOs.RequestDTOs.Abstracts
{
    public class BaseActivityRequestDTO:BaseRequestDTO
    {
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public int RegionId { get; set; }
    }
}
