using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Mappings;
using DataAccess.Entities.Models.Activities;

namespace DataAccess.Entities.Models.Regions
{
    public class ServiceRegion:BaseRegionModel
    {
        public bool TouristPopulation { get; set; }
        public bool HasAirport { get; set; }
        public bool HasHotelFacility { get; set; }
        //Mapping
        public virtual ICollection<ContractTourGuide_ServiceRegion>? ContractTourGuides_ServiceRegions { get; set; }
        public virtual ICollection<Event>? Events { get; set; }
        public virtual ICollection<Tour>? Tours { get; set; }
    }
}
