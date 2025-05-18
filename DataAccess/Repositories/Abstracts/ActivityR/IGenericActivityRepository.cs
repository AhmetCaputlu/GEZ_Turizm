using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Activities;

namespace DataAccess.Repositories.Abstracts.Activity
{
    public interface IGenericActivityRepository : IGenericRepository<Entities.Models.Activities.Activity, ActivityFilterModel>
    {
       //Geliştirmeye açık
    }
}
