using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Models.Activities
{
    public class Tour:BaseActivityModel
    {
        public TourCategory TourCategory { get; set; }
        //Mapping
        //ServiceRegion
        public int? RegionId { get; set; }
        public ServiceRegion? ServiceRegion { get; set; }
        //TourTicket
        public virtual ICollection<TourTicket>? TourTickets{ get; set; }
        //Vehicles
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
        public virtual ICollection<RentalVehicle>? RentalVehicles { get; set; }
    }
}
