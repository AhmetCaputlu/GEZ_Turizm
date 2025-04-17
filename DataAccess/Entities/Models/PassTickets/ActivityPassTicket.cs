using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Entities.Models.PassTickets
{
    public class ActivityPassTicket : BaseModel
    {
        public decimal Price { get; set; }
        public byte CommissionRate { get; set; }
        public decimal? TotalCostwithCommission { get { return (100 + CommissionRate) * Price / 100; } set { } }
        //Mapping
        public int? PartnerCompanyTransactionId { get; set; }
        public virtual PartnerCompanyTransaction? PartnerCompanyTransaction { get; set; }
    }
}
