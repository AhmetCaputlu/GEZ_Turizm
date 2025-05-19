using BusinessLogic.DTOs.OperationResult;
using BusinessLogic.DTOs.WebUser;
using DataAccess.Entities.Models.WebUsers;

namespace BusinessLogic.Services.Abstracts.WebUsers.Identity
{
    public interface IUserService
    {
        /// <summary>
        /// Yeni bir kullanıcı kaydı için bu metodu kullanın.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<ResultDTO> CreateUserAsync(WebUserAccountRequestDTO user, string password, CancellationToken token);
        /// <summary>
        /// Kullanıcı bilgilerini güncellemek için kullanın.Ek özellikler de güncellemeye tabiidir.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<ResultDTO> UpdateUserAsync(WebUserAccountRequestDTO user, CancellationToken token);
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
        Task<ResultDTO> AddToRoleAsync(WebUserAccount user, string role, CancellationToken token);
        /// <summary>
        /// İlgili kullanıcının seçili rolünü siler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<ResultDTO> RemoveFromRoleAsync(WebUserAccount user, string role, CancellationToken token);
        /// <summary>
        /// İlgili kullanıcının aranan role sahip olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<ResultDTO> IsInRoleAsync(WebUserAccount user, string role);
        /// <summary>
        /// İlgili role sahip tüm kullanıcıları döndürür.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<List<WebUserAccountResponseDTO>> GetUsersInRoleAsync(string roleName);
    }

}
