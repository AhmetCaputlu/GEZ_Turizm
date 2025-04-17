using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts.Activity
{
    public interface IGenericActivityRepository : IGenericRepository<Entities.Models.Activities.Activity> 
    {
        IQueryable<Entities.Models.Activities.Activity> SearchByActivityName(string activityName);
        IQueryable<Entities.Models.Activities.Activity> GetActivitiesByStartDate(DateTime dateTime);
        IQueryable<Entities.Models.Activities.Activity> SearchActivityByDescription(string description);
        IQueryable<Entities.Models.Activities.Activity> SearchActivityByRegionId(int regionId);
        IQueryable<Entities.Models.Activities.Activity> GetToursByEventCategory(ActivityCategory activityCategory);
    }
}
