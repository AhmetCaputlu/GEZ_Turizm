using DataAccess.Entities.Enums;
using DataAccess.Entities.Interfaces;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BaseRegionModel : BaseModel
    {
        public string DistrictName { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public VehicleType TransportVehicle { get; set; }
    }
}
