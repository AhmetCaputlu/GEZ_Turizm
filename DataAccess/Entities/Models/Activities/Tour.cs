using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Mappings;
using DataAccess.Entities.Models.Tickets;

namespace DataAccess.Entities.Models.Activities
{
    public class Tour:BaseActivityModel
    {
        public TourCategory TourCategory { get; set; }
        //Mapping

        //ContractTourGuide_Tour    
        public virtual ICollection<ContractTourGuide_Tour>? ContractTourGuides_Tours { get; set; }
        public virtual ICollection<TourTicket>? TourTickets { get; set; }
    }
}
