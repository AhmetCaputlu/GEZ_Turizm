using DataAccess.Context;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts.WebUserR;

namespace DataAccess.Repositories.Concretes.WebUserR
{
    public class WebUserAccountRepository : GenericRepository<WebUserAccount, WebUserAccountFilterModel>, IWebUserAccountRepository
    {
        private readonly GezTurizmContext _context;

        public WebUserAccountRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public override IQueryable<WebUserAccount> GetDynamicFilteredEntities(WebUserAccountFilterModel filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);
            if (filterModel.CountryId.HasValue)
            {
                filter = filter.Where(x => x.CountryId == filterModel.CountryId);
            }
            if (!string.IsNullOrWhiteSpace(filterModel.UserName))
            {
                filter = filter.Where(x => x.UserName != null && x.UserName.ToLower().Contains(filterModel.UserName.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(filterModel.Email))
            {
                filter = filter.Where(x => x.Email != null && x.Email.ToLower().Contains(filterModel.Email.ToLower()));
            }
            return filter;
        }
    }
}
