using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.WebUserR;

namespace DataAccess.Repositories.Concretes.WebUserR
{
    public class WebUserProfileRepository : GenericRepository<WebUserProfile, WebUserProfileFilterModel>, IWebUserProfileRepository
    {
        private readonly GezTurizmContext _context;

        public WebUserProfileRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }


        public override IQueryable<WebUserProfile> GetDynamicFilteredEntities(WebUserProfileFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (!string.IsNullOrEmpty(filterModel.Name))
            {
                filter = filter.Where(x => x.LastName.ToLower().Contains(filterModel.Name.ToLower()));
            }
            if (filterModel.Gender.HasValue)
            {
                filter = filter.Where(x => x.Gender == filterModel.Gender.Value);
            }
            if (filterModel.Descending != true && filterModel.DescendingAge.HasValue)
            {
                filter = filter.OrderByDescending(x => x.Age);
            }

            return filter;
        }
    }
}
