using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Vehicles
{
    public class VehicleRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public VehicleType VehicleType { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [StringLength(32, MinimumLength = 24, ErrorMessage = "Karakter uzunluğu max 11 karakter olabilir!(34 NPM 1283 gibi)")]
        public string LicensePlate { get; set; }
        [StringLength(200, ErrorMessage = "Karakter uzunluğu max 200 karakter olabilir!")]
        public string? Model { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(6000,9999999,ErrorMessage = "Araç kilometresi min 6000(0 araç) ve max 9.999.999 km olabilir!!")]
        public int Kilometer { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(0, 25, ErrorMessage = "Araç yaşı 0 ile 25 arası olabilir!!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(2, 99, ErrorMessage = "Araç kapasitesi 2 ile 99 arası olabilir!!")]
        public short Capacity { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime PurchaseDate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(1000000, 99999999, ErrorMessage = "Araç fiyatı 1.000.000 Tl ile 99.999.999 Tl arası olabilir!!")]
        public decimal MarketValue { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public int? ActivityId { get; set; }//Araç alındığı anda etkinliğe sevk edilmez ancak etkinlik bilgisi güncellenebilir.
    }
}
