using DataAccess.Entities.Enums;

namespace DataAccess.Entities.FilterModels.BaseModel
{
    public abstract class BaseFilterModel
    {
        public int? FirstId { get; set; } = null;
        public int? LastId { get; set; } = null;
        public DateTime? FirstCreatedDate { get; set; } = null;
        public DateTime? LastCreatedDate { get; set; } = null;
        public DateTime? FirstUpdatedDate { get; set; } = null;
        public DateTime? LastUpdatedDate { get; set; } = null;
        public DataStatus? Status { get; set; } = null;
        public bool? IsUpdated { get; set; } = null;
        public bool? Descending { get; set; } = null;
    }
}
