using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;

namespace DataAccess.Repositories.Abstracts.WebUserR
{
    /// <summary>
    /// Diğer Entity'lerden farklı olarak WebUserAccount sınıfının tüm işlemini Identity Kütüphanesinin managerları tarafından sağlanıyor.Dolayısıyla GenericRepository implementasyonlarıyla bağımlılığı yoktur.
    /// </summary>
    public interface IWebUserAccountRepository
    {
        public IQueryable<WebUserAccount> GetDynamicFilteredEntities(WebUserAccountFilterModel filterModel);
    }
}
