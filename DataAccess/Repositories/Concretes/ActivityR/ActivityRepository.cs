using Bogus.Extensions.Extras;
using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.Activities;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.Models.Activities;
using DataAccess.Repositories.Abstracts.Activity;

namespace DataAccess.Repositories.Concretes.Activity
{
    public class ActivityRepository : GenericRepository<Entities.Models.Activities.Activity, ActivityFilterModel>, IActivityRepository

    {
        private readonly GezTurizmContext _context;
        public ActivityRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        /// <summary>
        /// Override edilmiş metod.Nesne özelinde yapılan spesifik filtrelemeler için kullanılır.
        /// </summary>
        /// <param name="filterModel"></param>
        /// <returns></returns>
        public override IQueryable<Entities.Models.Activities.Activity> GetDynamicFilteredEntities(ActivityFilterModel filterModel)
        {
            IQueryable<Entities.Models.Activities.Activity> filter = base.GetDynamicFilteredEntities(filterModel);

            if (!string.IsNullOrEmpty(filterModel.ActivityName))
            {
                filter = filter.Where(x => x.ActivityName.ToLower().Contains(filterModel.ActivityName.ToLower()));
            }
            if (filterModel.StartDate.HasValue)
            {
                filter = filter.Where(x => x.StartDate.Date == filterModel.StartDate.Value.Date);
            }
            if (!string.IsNullOrEmpty(filterModel.Description))
            {
                filter = filter.Where(x => (x.Description ?? "").ToLower().Contains(filterModel.Description.ToLower()));
            }
            if (filterModel.RegionId.HasValue)
            {
                filter = filter.Where(x => x.RegionId == filterModel.RegionId.Value);
            }
            if (filterModel.ActivityCategory.HasValue)
            {
                filter = filter.Where(x => x.ActivityCategory == filterModel.ActivityCategory.Value);
            }
            return filter;
        }
    }
}
