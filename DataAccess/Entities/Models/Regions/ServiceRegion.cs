using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;

namespace DataAccess.Entities.Models.Regions
{
    public class ServiceRegion : BaseModel
    {
        public string DistrictName { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public VehicleType TransportVehicle { get; set; }
        public bool TouristPopulation { get; set; }
        public bool HasAirport { get; set; }
        public bool HasHotelFacility { get; set; }
        //Mapping
        public virtual ICollection<Activity>? Activities { get; set; }
    }
}
