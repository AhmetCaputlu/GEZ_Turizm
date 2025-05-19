using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Regions
{
    public class RegionFilterModel : BaseFilterModel
    {
        public string? DistrictName { get; set; } = null;
        public VehicleType? VehicleType { get; set; } = null;
        public bool? DescendingByArrivalTime { get; set; } = null;
    }
}
