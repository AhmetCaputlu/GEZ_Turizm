using BusinessLogic.DTOs.OperationResult;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BusinessLogic.Services.Abstracts.WebUsers.Identity
{
    public interface IRoleService
    {
        /// <summary>
        /// İlgili rolün var olup olmadığını sorgular.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<ResultDTO> RoleExistsAsync(string roleName);
        /// <summary>
        /// Yeni bir rol yaratır.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<ResultDTO> CreateRoleAsync(string roleName, CancellationToken token);
        /// <summary>
        /// Rolü siler.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<ResultDTO> DeleteRoleAsync(string roleName, CancellationToken token);
        /// <summary>
        /// Tüm rolleri döndürür.
        /// </summary>
        /// <returns></returns>
        Task<List<IdentityRole<int>>> GetAllRolesAsync();

    }
}
