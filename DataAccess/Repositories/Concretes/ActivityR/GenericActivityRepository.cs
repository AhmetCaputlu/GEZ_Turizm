using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.Activity;

namespace DataAccess.Repositories.Concretes.Activity
{
    public class GenericActivityRepository : GenericRepository<Entities.Models.Activities.Activity>, IGenericActivityRepository
      
    {
        private readonly GezTurizmContext _context;
        public GenericActivityRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<Entities.Models.Activities.Activity> GetToursByEventCategory(ActivityCategory activityCategory)
        {
            return _context.Activities.Where(x => x.ActivityCategory == activityCategory);
        }

        public IQueryable<Entities.Models.Activities.Activity> SearchByActivityName(string activityName)
        {
            var selectedItems = _context.Activities.Where(x => x.ActivityName.ToLower().Contains(activityName.ToLower()));
            return selectedItems;
        }

        public IQueryable<Entities.Models.Activities.Activity> GetActivitiesByStartDate(DateTime dateTime)
        {
            var selectedItems = _context.Activities.Where(x => x.StartDate.Date == dateTime.Date);
            return selectedItems;
        }

        public IQueryable<Entities.Models.Activities.Activity> SearchActivityByDescription(string description)
        {
            var selectedItems = _context.Activities.Where(x =>x.Description != null && x.Description.ToLower().Contains(description.ToLower()));
            return selectedItems;
        }

        public IQueryable<Entities.Models.Activities.Activity> SearchActivityByRegionId(int regionId)
        {
            var selectedItems = _context.Activities.Where(x => x.RegionId == regionId);
            return selectedItems;
        }
    }
}
