using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BasePassTicketModel:BaseModel
    {
        public decimal Price { get; set; }
        public byte CommissionRate { get; set; }
        public decimal? TotalCostwithCommission { get { return (100 + CommissionRate) * Price / 100; } set { } }
        //Mapping
        public int? PartnerCompanyTransactionId { get; set; }
        public virtual PartnerCompanyTransaction? PartnerCompanyTransaction { get; set; }
    }
}
