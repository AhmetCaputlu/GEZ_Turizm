using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.Employees;

namespace DataAccess.Entities.Mappings
{
    public class ContractTourGuide_Tour
    {
        public int? ContractTourGuideId { get; set; }
        public virtual ContractTourGuide? ContractTourGuide { get; set; }
        public int? TourId { get; set; }
        public virtual Tour? Tour { get; set; }
    }
}
