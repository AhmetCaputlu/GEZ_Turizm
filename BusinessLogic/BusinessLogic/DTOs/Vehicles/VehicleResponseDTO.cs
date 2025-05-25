using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Activities;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Vehicles
{
    public class VehicleResponseDTO : BaseVehicleResponseDTO
    {
        public DateTime PurchaseDate { get; set; }
        public decimal MarketValue { get; set; }
        public ActivityResponseDTO? ActivityResponseDTO { get; set; }
    }
}
