using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Countries
{
    public class CountryResponseDTO : BaseResponseModelDTO
    {
        public Continent Continent { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string? CountryDescription { get; set; }
        public string CountryPhone { get; set; }
    }
}
