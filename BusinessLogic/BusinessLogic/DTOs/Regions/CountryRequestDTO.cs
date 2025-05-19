using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Regions
{
    public class CountryRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public Continent Continent { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public string CountryName { get; set; }
    }
}
