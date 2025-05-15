using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Services.Abstracts.Identity
{
    public interface IRoleService
    {
        /// <summary>
        /// İlgili rolün var olup olmadığını sorgular.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<bool> RoleExistsAsync(string roleName);
        /// <summary>
        /// Yeni bir rol yaratır.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<IdentityResult> CreateRoleAsync(string roleName);
        /// <summary>
        /// Rolü siler.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<IdentityResult> DeleteRoleAsync(string roleName);
        /// <summary>
        /// İlgili role sahip tüm kullanıcıları döndürür.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<List<WebUserAccount>> GetUsersInRoleAsync(string roleName);
        /// <summary>
        /// Tüm rolleri döndürür.
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetAllRolesAsync();

    }
}
