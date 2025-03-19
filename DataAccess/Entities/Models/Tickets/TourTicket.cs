using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Entities.Models.Tickets
{
    public class TourTicket:BaseTicketModel
    {
        //Mapping
        //WebUserAccount

        //Tour
        public int? TourId { get; set; }
        public virtual Tour? Tour { get; set; }
    }
}
