using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Activities;
using BusinessLogic.DTOs.Companies.Suppliers;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Vehicles
{
    public class RentalVehicleResponseDTO : BaseResponseModelDTO
    {
        public string LicensePlate { get; set; }
        public VehicleType VehicleType { get; set; }
        public short Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime PurchaseDate { get; set; }
        public ActivityResponseDTO? ActivityResponseDTO { get; set; }
        public decimal DailyRentalFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int TotalRentalDay { get { return (ExpireDate - StartDate).Days; }}
        public decimal TotalPrice { get { return DailyRentalFee * TotalRentalDay; }}
        public RentalVehicleSupplierResponseDTO? RentalVehicleSupplierResponseDTO { get; set; }
    }
}
