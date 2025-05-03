using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.WebUserR;

namespace DataAccess.Repositories.Concretes.WebUserR
{
    public class WebUserProfileRepository : GenericRepository<WebUserProfile>, IGenericRepository<WebUserProfile>, IWebUserProfileRepository
    {
        private readonly GezTurizmContext _context;

        public WebUserProfileRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<WebUserProfile> GetDynamicUserProfileFilter(string? name = null, Gender? gender = null, bool? descendingAge = null, bool? descending = null)
        {
            IQueryable<WebUserProfile> filter = _context.AspNetUserProfiles;
            if (!string.IsNullOrEmpty(name))
            {
                filter = filter.Where(x => x.LastName.ToLower().Contains(name.ToLower()));
            }
            if (gender.HasValue)
            {
                filter = filter.Where(x => x.Gender == gender.Value);
            }
            if (descendingAge.HasValue)
            {
                filter = filter.OrderByDescending(x => x.LastName);
            }
            else if (descending.HasValue)
            {
                filter = filter.OrderByDescending(x => x.WebUserAccountId);
            }
            return filter;
        }
    }
}
