using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Interfaces;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Repositories.WebUserR
{
    /// <summary>
    /// Diğer Entity'lerden farklı olarak WebUserAccount sınıfının tüm işlemini Identity Kütüphanesinin managerları tarafından sağlanıyor.Dolayısıyla GenericRepository implementasyonlarıyla bağımlılığı yoktur.
    /// </summary>
    public interface IWebUserAccountRepository
    {
        IQueryable<WebUserAccount> GetDynamicFilteredEntities(WebUserAccountFilterModel filterModel);
        Task<WebUserAccount?> GetByIdAsync(int? Id);
    }
}
