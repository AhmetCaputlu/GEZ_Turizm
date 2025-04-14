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

        public IQueryable<WebUserProfile> GetUsersByAgeDesc()
        {
            return _context.AspNetUserProfiles.OrderByDescending(x => x.Age);
        }

        public IQueryable<WebUserProfile> GetUsersByGender(Gender gender)
        {
            return _context.AspNetUserProfiles.Where(x => x.Gender == gender);
        }

        public IQueryable<WebUserProfile> GetUsersByName(string name)
        {
            return _context.AspNetUserProfiles.Where(x => x.FirstName.ToLower().Contains(name.ToLower()));
        }
    }
}
