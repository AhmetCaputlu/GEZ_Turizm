using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.Activities;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseVehicleModel : BaseModel
    {
        public VehicleType VehicleType { get; set; }
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public int Kilometer { get; set; }
        public int Age { get; set; }
        public short Capacity { get; set; }
        //Mapping
        public int? TourId { get; set; }
        public virtual Tour? Tour { get; set; }
        public int? EventId { get; set; }
        public virtual Event? Event { get; set; }
    }
}
