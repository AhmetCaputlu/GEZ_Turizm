using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts.WebUserR;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.WebUserR
{
    /// <summary>
    /// Diğer Entity'lerden farklı olarak WebUserAccount sınıfının tüm işlemini Identity Kütüphanesinin managerları tarafından sağlanıyor.Dolayısıyla GenericRepository implementasyonlarıyla bağımlılığı yoktur.
    /// </summary>
    public class WebUserAccountRepository : IWebUserAccountRepository
    {
        private readonly GezTurizmContext _context;

        public WebUserAccountRepository(GezTurizmContext context)
        {
            _context = context;
        }

        public async Task<WebUserAccount?> GetByIdAsync(int? Id)
        {
            return await _context.AspNetUsers.FindAsync(Id);
        }

        public IQueryable<WebUserAccount> GetDynamicFilteredEntities(WebUserAccountFilterModel filterModel)
        {
            IQueryable<WebUserAccount> filter = _context.AspNetUsers;
            if (filterModel.FirstId.HasValue && filterModel.LastId.HasValue)
            {
                filter = filter.Where(x => x.Id >= filterModel.FirstId && x.Id <= filterModel.LastId);
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
            {
                filter = filter.OrderByDescending(x => x.Id);
            }
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
