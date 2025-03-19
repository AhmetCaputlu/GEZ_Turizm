using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseActivityModel : BaseModel
    {
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
    }
}
