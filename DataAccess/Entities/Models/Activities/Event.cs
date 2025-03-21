using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Regions;
using DataAccess.Entities.Models.Tickets;
using DataAccess.Entities.Models.Vehicles;

namespace DataAccess.Entities.Models.Activities
{
    public class Event:BaseActivityModel
    {
        public EventCategory EventCategory { get; set; }
        //Mapping
        public virtual ICollection<EventTicket>? EventTickets { get; set; }

    }
}
