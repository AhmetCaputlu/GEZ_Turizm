using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.BaseModel;

namespace DataAccess.Entities.FilterModels.Vehicles
{
    public class BaseVehicleFilterModel : BaseFilterModel
    {
        public VehicleType? VehicleType { get; set; } = null;
        public string? LicensePlate { get; set; } = null;
        public string? Model { get; set; } = null;
        public bool? Available { get; set; } = null;
    }
}
