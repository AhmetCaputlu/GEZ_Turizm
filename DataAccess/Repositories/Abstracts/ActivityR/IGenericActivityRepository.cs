using DataAccess.Entities.Enums;

namespace DataAccess.Repositories.Abstracts.Activity
{
    public interface IGenericActivityRepository : IGenericRepository<Entities.Models.Activities.Activity> 
    {
        IQueryable<Entities.Models.Activities.Activity> GetDynamicActivityFilter(
            string? activityName = null,
            DateTime? dateTime = null,
            string? description = null,
            int? regionId = null,
            ActivityCategory? activityCategory = null,
            bool? descending = null
            );
            
    }
}
