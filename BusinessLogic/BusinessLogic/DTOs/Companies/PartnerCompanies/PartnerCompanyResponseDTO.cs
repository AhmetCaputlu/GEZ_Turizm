using System.Diagnostics;
using BusinessLogic.DTOs.Abstracts;

namespace BusinessLogic.DTOs.Companies.PartnerCompanies
{
    public class PartnerCompanyResponseDTO:BaseResponseModelDTO
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public bool AcceptTickets { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get { return Debit - Credit; }}
    }
}
