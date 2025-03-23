using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Entities.Abstracts
{
    public abstract class BasePassTicketModel:BaseTicketModel
    {
        public byte CommissionRate { get; set; }
        public virtual decimal TotalCostwithCommission { get; }
        //Mapping
        public int? PartnerCompanyTransactionId { get; set; }
        public virtual PartnerCompanyTransaction? PartnerCompanyTransaction { get; set; }
    }
}
