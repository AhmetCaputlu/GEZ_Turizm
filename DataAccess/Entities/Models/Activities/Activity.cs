using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Models.Activities
{
    public class Activity:BaseModel
    {
        public string ActivityName { get; set; }
        public ActivityCategory ActivityCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        //Mapping
        public int? RegionId { get; set; }
        public virtual ServiceRegion? ServiceRegion { get; set; }
        public virtual ICollection<ActivityTicket>? ActivityTickets { get; set; }
        //Vehicles
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
        public virtual ICollection<RentalVehicle>? RentalVehicles { get; set; }
    }
}
