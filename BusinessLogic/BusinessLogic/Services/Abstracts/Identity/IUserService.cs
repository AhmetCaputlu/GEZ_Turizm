using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Services.Abstracts.Identity
{
    public interface IUserService
    {
        /// <summary>
        /// Yeni bir kullanıcı Kaydı için bu metodu kullanın.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<IdentityResult> CreateUserAsync(WebUserAccount user, string password);
        /// <summary>
        /// Kullanıcı bilgilerini güncellemek için kullanın.Ek özellikler de güncellemeye tabiidir.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<IdentityResult> UpdateUserAsync(WebUserAccount user, string password);
        /// <summary>
        /// İlgili kullanıcının rollerini listeler.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<List<string>> GetUserRolesAsync(WebUserAccount user);
        /// <summary>
        /// İlgili kullanıcıya yeni bir rol ekler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<IdentityResult> AddToRoleAsync(WebUserAccount user, string role);
        /// <summary>
        /// İlgili kullanıcının seçili rolünü siler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<IdentityResult> RemoveFromRoleAsync(WebUserAccount user, string role);
        /// <summary>
        /// İlgili kullanıcının aranan role sahip olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        Task<bool> IsInRoleAsync(WebUserAccount user, string role);
    }

}
