using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.PassTickets;

namespace DataAccess.Entities.Models.Companies.PartnerCompanies
{
    public class PartnerCompanyTransaction : BaseModel
    {
        public TransactionType Type { get; set; }
        public decimal TotalCost { get; set; }

        //Mapping
        public int? PartnerCompanyId { get; set; }
        public virtual PartnerCompany? PartnerCompany { get; set; }
        public virtual ICollection<ActivityPassTicket>? ActivityPassTickets { get; set; }

    }
}
