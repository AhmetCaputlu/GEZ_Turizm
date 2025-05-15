using BusinessLogic.DTOs.Abstracts;
using DataAccess.Entities.Enums;

namespace BusinessLogic.DTOs.Companies.PartnerCompanies
{
    public class TransactionRequestDTO : BaseRequestModelDTO
    {
        public TransactionType Type { get; set; }
        public decimal TotalCost { get; set; }

        //Mapping
        public int? PartnerCompanyId { get; set; }
    }
}
