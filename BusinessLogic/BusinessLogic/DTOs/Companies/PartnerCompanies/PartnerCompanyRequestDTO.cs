using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.Companies.PartnerCompanies
{
    public class PartnerCompanyRequestDTO:BaseCompanyRequestDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public bool AcceptTickets { get; set; }
    }
}
