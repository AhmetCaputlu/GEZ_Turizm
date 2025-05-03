using Bogus.Extensions.Extras;
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

        public IQueryable<Entities.Models.Activities.Activity> GetDynamicActivityFilter(string? activityName = null, DateTime? dateTime = null, string? description = null, int? regionId = null, ActivityCategory? activityCategory = null, bool? descending = null)
        {
            IQueryable<Entities.Models.Activities.Activity> filter = _context.Activities;

            if (!string.IsNullOrEmpty(activityName))
            {
                filter = filter.Where(x => x.ActivityName.ToLower().Contains(activityName.ToLower()));
            }
            if (dateTime.HasValue)
            {
                filter = filter.Where(x => x.StartDate.Date == dateTime.Value.Date);
            }
            if (!string.IsNullOrEmpty(description))
            {
                filter = filter.Where(x => (x.Description ?? "").ToLower().Contains(description.ToLower()));
            }
            if (regionId.HasValue)
            {
                filter = filter.Where(x => x.RegionId == regionId.Value);
            }
            if (activityCategory.HasValue)
            {
                filter = filter.Where(x => x.ActivityCategory == activityCategory.Value);
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }

            return filter;
        }
    }
}
