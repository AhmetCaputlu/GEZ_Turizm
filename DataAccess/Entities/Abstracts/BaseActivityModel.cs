using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseActivityModel : BaseModel
    {
        public string EventName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        //Mapping
        public int? RegionId { get; set; }
        public virtual ServiceRegion? ServiceRegion { get; set; }
        
        //Vehicles
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
        public virtual ICollection<RentalVehicle>? RentalVehicles { get; set; }
    }
}
