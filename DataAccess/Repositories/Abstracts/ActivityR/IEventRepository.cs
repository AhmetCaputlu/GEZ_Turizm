using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;

namespace DataAccess.Repositories.Abstracts.Activity
{
    public interface IEventRepository : IGenericActivityRepository<Event>
    {
        IQueryable<Event> GetToursByEventCategory(EventCategory eventCategory);
    }
}
