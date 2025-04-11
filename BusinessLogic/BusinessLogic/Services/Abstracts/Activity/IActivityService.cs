using BusinessLogic.DTOs.BasicDTOs.Abstracts;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Interfaces;

namespace BusinessLogic.Services.Abstracts.Activity
{
    public interface IActivityService<T, F> : IService<T, F> where T : class, IEntity where F : BaseModelDTO
    {
        IEnumerable<T> SearchByActivityName(string activityName);
        IEnumerable<T> GetActivitiesByStartDate(DateTime dateTime);
        IEnumerable<T> SearchActivityByDescription(string description);
        IEnumerable<T> SearchActivityByRegionId(int regionId);
    }
}
