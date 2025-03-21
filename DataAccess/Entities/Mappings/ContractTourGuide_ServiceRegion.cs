using DataAccess.Entities.Models.Employees;
using DataAccess.Entities.Models.Regions;

namespace DataAccess.Entities.Mappings
{
    public class ContractTourGuide_ServiceRegion
    {
        public int? ContractTourGuideId { get; set; }
        public virtual ContractTourGuide? ContractTourGuide { get; set; }
        public int? ServiceRegionId { get; set; }
        public virtual ServiceRegion? ServiceRegion { get; set; }
    }
}
