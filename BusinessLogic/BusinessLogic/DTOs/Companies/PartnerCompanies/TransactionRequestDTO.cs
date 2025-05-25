using System.ComponentModel.DataAnnotations;
using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Companies.PartnerCompanies
{
    public class TransactionRequestDTO : BaseRequestModelDTO
    {
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public TransactionType Type { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public decimal TotalCost { get; set; }

        //Mapping
        [Required(ErrorMessage = "Bu alan zorunludur!!")]
        public int PartnerCompanyId { get; set; }
    }
}
