using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Activities;

namespace DataAccess.Repositories.ActivityR
{
    public interface IActivityRepository : IGenericRepository<Entities.Models.Activities.Activity, ActivityFilterModel>
    {

    }
}
