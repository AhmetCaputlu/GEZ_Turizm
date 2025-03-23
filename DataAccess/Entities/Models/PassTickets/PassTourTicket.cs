using System.ComponentModel.DataAnnotations.Schema;
using DataAccess.Entities.Abstracts;

namespace DataAccess.Entities.Models.PassTickets
{
    public class PassTourTicket:BasePassTicketModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public override decimal TotalCostwithCommission
        {
            get { return (1 + CommissionRate <= 1.1 && Price > 0) ? ((1 + CommissionRate) * Price) : 0; }
        }
    }
}
