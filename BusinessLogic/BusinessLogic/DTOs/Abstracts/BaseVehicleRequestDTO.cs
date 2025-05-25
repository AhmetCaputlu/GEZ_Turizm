using DataAccess.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.DTOs.Abstracts
{
    public abstract class BaseVehicleRequestDTO : BaseRequestModelDTO
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

    }
}
