using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Abstracts.WebUserR;
using Microsoft.EntityFrameworkCore;

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
            #region Önemli Uyarı
            /*
               WebUserProfile sınıfı için Id özelliği ignore edilmişti.
               Dolayısıyla base'den gelen filtreleme teknikleri hata almamıza sebep oluyor.(Id'den dolayı)
               WebUserProfile sınıfı için PK özelliği, FK ile bir arada WebUserAccountId property'si ile sağlanıyor!!
            */
            #endregion
            IQueryable<WebUserProfile> filter = _context.AspNetUserProfiles;

            if (filterModel.FirstId.HasValue && filterModel.LastId.HasValue)
            {
                filter = filter.Where(x => x.WebUserAccountId >= filterModel.FirstId && x.WebUserAccountId <= filterModel.LastId);
            }
            if (filterModel.FirstCreatedDate.HasValue && filterModel.LastCreatedDate.HasValue)
            {
                filter = filter.Where(x =>
                x.CreatedDate.Date >= filterModel.FirstCreatedDate.Value.Date &&
                x.CreatedDate.Date <= filterModel.LastCreatedDate.Value.Date);
            }
            else if (filterModel.FirstCreatedDate.HasValue)
            {
                filter = filter.Where(x => x.CreatedDate.Date >= filterModel.FirstCreatedDate.Value.Date);
            }
            else if (filterModel.LastCreatedDate.HasValue)
            {
                filter = filter.Where(x => x.CreatedDate.Date <= filterModel.LastCreatedDate.Value.Date);
            }
            if (filterModel.FirstUpdatedDate.HasValue && filterModel.LastUpdatedDate.HasValue)
            {
                filter = filter.Where(x =>
                x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date >= filterModel.FirstUpdatedDate.Value.Date &&
               x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date <= filterModel.LastUpdatedDate.Value.Date);
            }
            else if (filterModel.FirstUpdatedDate.HasValue)
            {
                filter = filter.Where(x => x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date >= filterModel.FirstUpdatedDate.Value.Date);
            }
            else if (filterModel.LastUpdatedDate.HasValue)
            {
                filter = filter.Where(x => x.UpdatedDate.HasValue && x.UpdatedDate.Value.Date <= filterModel.LastUpdatedDate.Value.Date);
            }
            if (filterModel.Status.HasValue)
            {
                filter = filter.Where(x => x.Status == filterModel.Status.Value);
            }
            if (filterModel.IsUpdated.HasValue)
            {
                filter = filter.Where(x => x.IsUpdated == filterModel.IsUpdated.Value);
            }
            if (filterModel.Descending == true)
                filter = filter.OrderByDescending(x => x.WebUserAccountId);
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
