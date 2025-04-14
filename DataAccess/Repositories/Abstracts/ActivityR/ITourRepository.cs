using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;

namespace DataAccess.Repositories.Abstracts.Activity
{
    public interface ITourRepository : IGenericActivityRepository<Tour>
    {
        IQueryable<Tour> GetToursByTourCategory(TourCategory tourCategory);
    }
}
