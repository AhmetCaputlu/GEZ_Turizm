using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Vehicles
{
    public class VehicleRequestDTO : BaseVehicleRequestDTO
    {
        [StringLength(200, ErrorMessage = "Karakter uzunluğu max 200 karakter olabilir!")]
        public string? Model { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime PurchaseDate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(1000000, 99999999, ErrorMessage = "Araç fiyatı 1.000.000 Tl ile 99.999.999 Tl arası olabilir!!")]
        public decimal MarketValue { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public int? ActivityId { get; set; }//Araç alındığı anda etkinliğe sevk edilmez ancak etkinlik bilgisi güncellenebilir.
    }
}
