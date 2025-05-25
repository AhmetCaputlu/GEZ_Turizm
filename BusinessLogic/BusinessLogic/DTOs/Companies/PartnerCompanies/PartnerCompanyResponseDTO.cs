using System.Diagnostics;
using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.Companies.PartnerCompanies
{
    public class PartnerCompanyResponseDTO : BaseCompanyResponseDTO
    {
        public bool AcceptTickets { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get { return Debit - Credit; } }
    }
}
