using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Activities;

namespace DataAccess.Repositories.Abstracts
{
    public interface IActivityRepository<T>:IRepository<T> where T : BaseActivityModel
    {
        IQueryable<T> SearchByActivityName(string activityName);
        IQueryable<T> GetActivitiesByStartDate(DateTime dateTime);
        IQueryable<T> SearchActivityByDescription(string description);
        IQueryable<T> SearchActivityByRegionId(int regionId);
    }
}
