using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Mappings;

namespace DataAccess.Entities.Models.Activities
{
    public class Tour:BaseActivityModel
    {
        public TourCategory TourCategory { get; set; }
        //Mapping
    
        //TourTicket
        //ContractTourGuide_Tour    
        public virtual ICollection<ContractTourGuide_Tour>? ContractTourGuides_Tours { get; set; }
    }
}
