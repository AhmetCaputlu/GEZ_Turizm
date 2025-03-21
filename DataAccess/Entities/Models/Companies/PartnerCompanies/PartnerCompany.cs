using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Abstracts;

namespace DataAccess.Entities.Models.Companies.PartnerCompanies
{
    public class PartnerCompany:BaseCompanyModel
    {
        public decimal CommissionRate { get; set; }
        public bool AcceptTickets { get; set; }
        //PartnerCompanyTransaction
        public virtual ICollection<PartnerCompanyTransaction>? PartnerCompanyTransactions { get; set; }
    }
}
