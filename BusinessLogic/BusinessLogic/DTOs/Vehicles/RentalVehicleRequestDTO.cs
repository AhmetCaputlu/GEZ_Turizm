using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Vehicles
{
    public class RentalVehicleRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public VehicleType VehicleType { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(32, MinimumLength = 24, ErrorMessage = "Karakter uzunluğu max 11 karakter olabilir!(34 NPM 1283 gibi)")]
        public string LicensePlate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(6000, 9999999, ErrorMessage = "Araç kilometresi min 6000(0 araç) ve max 9.999.999 km olabilir!!")]
        public int Kilometer { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(0, 25, ErrorMessage = "Araç yaşı 0 ile 25 arası olabilir!!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(2, 99, ErrorMessage = "Araç kapasitesi 2 ile 99 arası olabilir!!")]
        public short Capacity { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public bool IsAvailable { get; set; }
        public int? ActivityId { get; set; }//Nav Property
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(1000, 999999, ErrorMessage = "Araç günlük kiralama bedeli 1000 ile 999.999 arası olabilir!!")]
        public decimal DailyRentalFee { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime ExpireDate { get; set; }
        public int TotalRentalDay { get { return (ExpireDate - StartDate).Days; }}
        public decimal TotalPrice { get { return DailyRentalFee * TotalRentalDay; }}
        public int? RentalVehicleSupplierId { get; set; }//Nav Property
    }
}
