using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Regions
{
    public class ServiceRegionRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public string DistrictName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public TimeSpan ArrivalTime { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public VehicleType TransportVehicle { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public bool TouristPopulation { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public bool HasAirport { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public bool HasHotelFacility { get; set; }
    }
}
