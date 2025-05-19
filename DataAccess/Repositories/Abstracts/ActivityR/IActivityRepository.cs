using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Activities;

namespace DataAccess.Repositories.Abstracts.Activity
{
    public interface IActivityRepository : IGenericRepository<Entities.Models.Activities.Activity, ActivityFilterModel>
    {
       //Geliştirmeye açık
    }
}
