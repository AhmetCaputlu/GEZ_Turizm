using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Activities;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Vehicles
{
    public class VehicleResponseDTO : BaseResponseModelDTO
    {
        public string LicensePlate { get; set; }
        public VehicleType VehicleType { get; set; }
        public short Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime PurchaseDate { get; set; }
        public ActivityResponseDTO? ActivityResponseDTO { get; set; }
    }
}
