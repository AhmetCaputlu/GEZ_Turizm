using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Abstracts;

namespace DataAccess.Entities.Models.Companies.PartnerCompanies
{
    public class PartnerCompany:BaseCompanyModel
    {
        public bool AcceptTickets { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Balance { get { return Debit - Credit; } set { } }
        public virtual ICollection<PartnerCompanyTransaction>? PartnerCompanyTransactions { get; set; }
    }
}
