using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.Regions
{
    public class ServiceRegionResponseDTO : BaseResponseModelDTO
    {
        public string DistrictName { get; set; }
        public bool TouristPopulation { get; set; }
        public bool HasAirport { get; set; }
        public bool HasHotelFacility { get; set; }
    }
}
