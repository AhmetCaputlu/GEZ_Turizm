using BusinessLogic.DTOs.Abstracts;
using BusinessLogic.DTOs.Companies.PartnerCompanies;

namespace BusinessLogic.DTOs.PassTickets
{
    public class PassTicketResponseDTO : BaseResponseModelDTO
    {
        public decimal Price { get; set; }
        public byte CommissionRate { get; set; }
        public decimal? TotalCostwithCommission { get { return (100 + CommissionRate) * Price / 100; } set { } }
        public TransactionResponseDTO? TransactionResponseDTO { get; set; }

    }
}
