using BusinessLogic.DTOs.WebUser;
using BusinessLogic.OperationResult;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Services.Abstracts.WebUsers.Identity
{
    public interface IUserService
    {
        /// <summary>
        /// Filtrelemeler doğrultusunda kullanıcıya ilgili hesapları dönecek olan metot.
        /// </summary>
        /// <returns></returns>
        Task<ResultDTO<WebUserAccountResponseDTO, WebUserAccountFilterModel>> DynamicWebUserFilter(ResultDTO<WebUserAccountResponseDTO, WebUserAccountFilterModel> filterModel);

        /// <summary>
        /// Yeni bir kullanıcı kaydı için bu metodu kullanın.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<NotificationDTO> CreateUserAsync(WebUserAccountRequestDTO user, string password, CancellationToken token);
        /// <summary>
        /// Kullanıcının aktiflik durumunu pasife çekmek için kullanın.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Task<NotificationDTO> DeleteUserAsync(int ID);
        /// <summary>
        /// Kullanıcıyı veritabanından tamamen silmek için kullanın.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Task<NotificationDTO> DestroyUserAsync(int ID);
        /// <summary>
        /// Kullanıcı bilgilerini güncellemek için kullanın.Ek özellikler de güncellemeye tabiidir.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<NotificationDTO> UpdateUserAsync(WebUserAccountRequestDTO user, CancellationToken token);
        /// <summary>
        /// İlgili kullanıcının rollerini listeler.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<IList<string>> GetUserRolesAsync(int Id);
        /// <summary>
        /// İlgili kullanıcıya yeni bir rol ekler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<NotificationDTO> AddToRoleAsync(WebUserAccount user, string role, CancellationToken token);
        /// <summary>
        /// İlgili kullanıcının seçili rolünü siler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<NotificationDTO> RemoveFromRoleAsync(WebUserAccount user, string role, CancellationToken token);
        /// <summary>
        /// İlgili kullanıcının aranan role sahip olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<NotificationDTO> IsInRoleAsync(WebUserAccount user, string role);
        /// <summary>
        /// İlgili role sahip tüm kullanıcıları döndürür.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<List<WebUserAccountResponseDTO>> GetUsersInRoleAsync(string roleName);
    }

}
