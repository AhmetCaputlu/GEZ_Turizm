using BusinessLogic.Services.Abstracts.Identity;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Services.Concretes.Identity
{
    public class IdentityService : IRoleService, ISignInService, IUserService
    {
        private readonly UserManager<WebUserAccount> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<WebUserAccount> _signInManager;
        public IdentityService(UserManager<WebUserAccount> userManager, RoleManager<IdentityRole> roleManager, SignInManager<WebUserAccount> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public Task<IdentityResult> CreateUserAsync(WebUserAccount user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateUserAsync(WebUserAccount user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetUserRolesAsync(WebUserAccount user)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> AddToRoleAsync(WebUserAccount user, string role)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> RemoveFromRoleAsync(WebUserAccount user, string role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(WebUserAccount user, string role)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RoleExistsAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<List<WebUserAccount>> GetUsersInRoleAsync(string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> CanSignInAsync(WebUserAccount user)
        {
            throw new NotImplementedException();
        }
    }
}
