using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Activities;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Entities.Models.Tickets
{
    public class EventTicket:BaseTicketModel
    {
        //Mapping
        //Event
        public int? EventId { get; set; }
        public virtual Event? Event { get; set; }

    }
}
