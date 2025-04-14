using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using DataAccess.Repositories.Abstracts.Activity;

namespace DataAccess.Repositories.Concretes.Activity
{
    public class EventRepository : GenericActivityRepository<Event>, IGenericActivityRepository<Event>, IEventRepository
    {
        private readonly GezTurizmContext _context;

        public EventRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Event> GetToursByEventCategory(EventCategory eventCategory)
        {
            return _context.Events.Where(x => x.EventCategory == eventCategory);
        }
    }
}
