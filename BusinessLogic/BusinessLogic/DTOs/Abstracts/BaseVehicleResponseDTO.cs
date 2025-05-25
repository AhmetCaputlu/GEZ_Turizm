using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseVehicleResponseDTO : BaseResponseModelDTO
    {
        public string LicensePlate { get; set; }
        public VehicleType VehicleType { get; set; }
        public short Capacity { get; set; }
        public bool IsAvailable { get; set; }
    }
}
