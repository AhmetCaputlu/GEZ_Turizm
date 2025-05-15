using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace BusinessLogic.DTOs.Companies.PartnerCompanies
{
    public class TransactionResponseDTO : BaseResponseModelDTO
    {
        public TransactionType Type { get; set; }
        public decimal TotalCost { get; set; }
        public virtual PartnerCompanyResponseDTO? PartnerCompanyResponseDTO { get; set; }
    }
}
