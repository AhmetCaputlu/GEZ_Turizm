using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Activities
{
    public class ActivityFilterModel : BaseFilterModel
    {
        public string? ActivityName { get; set; } = null;
        public DateTime? StartDate { get; set; } = null;
        public string? Description { get; set; } = null;
        public int? RegionId { get; set; } = null;
        public ActivityCategory? ActivityCategory { get; set; } = null;
    }
}
