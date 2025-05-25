using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Vehicles
{
    public class RentalVehicleRequestDTO : BaseVehicleRequestDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        [Range(1000, 999999, ErrorMessage = "Araç günlük kiralama bedeli 1000 ile 999.999 arası olabilir!!")]
        public decimal DailyRentalFee { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public DateTime ExpireDate { get; set; }
        public int? RentalVehicleSupplierId { get; set; }//Nav Property
    }
}
