using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.PassTickets;

namespace DataAccess.Entities.Models.Companies.PartnerCompanies
{
    public class PartnerCompanyTransaction:BaseModel
    {
        public decimal Debt { get; set; }
        public decimal Receive { get; set; }
        public decimal Balance { get; set; }
        //Mapping
        public int? PartnerCompanyId { get; set; }
        public virtual PartnerCompany? PartnerCompany { get; set; }
        public virtual ICollection<PassEventTicket>? PassEventTickets{ get; set; }
        public virtual ICollection<PassTourTicket>? PassTourTickets { get; set; }

    }
}
