using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Companies.PartnerCompanies;

namespace DataAccess.Entities.Models.PassTickets
{
    public class PassEventTicket : BasePassTicketModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public override decimal TotalCostwithCommission
        {
            get { return (1 + CommissionRate <= 1.2 && Price > 0) ? ((1 + CommissionRate) * Price) : 0; }
        }
    }
}
