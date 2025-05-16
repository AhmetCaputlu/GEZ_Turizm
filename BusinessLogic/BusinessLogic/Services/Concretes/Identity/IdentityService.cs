using System.Security.Claims;
using AutoMapper;
using Bogus;
using BusinessLogic.DTOs.SignIn_SignUpDTOs;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Services.Abstracts.Identity;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Services.Concretes.Identity
{
    public class IdentityService : IRoleService, ISignInService, IUserService
    {
        private readonly UserManager<WebUserAccount> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly SignInManager<WebUserAccount> _signInManager;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<WebUserAccount> _repository;
        private readonly IHttpContextAccessor _accessor;
        public IdentityService(UserManager<WebUserAccount> userManager, RoleManager<IdentityRole<int>> roleManager, SignInManager<WebUserAccount> signInManager, IGenericRepository<WebUserAccount> repository, IMapper mapper,IHttpContextAccessor accessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _repository = repository;
            _accessor = accessor;
        }
        /// <summary>
        /// Yeni bir kullanıcı kaydı için bu metodu kullanın.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<IdentityResult> CreateUserAsync(WebUserAccountRequestDTO user, string password, CancellationToken token)
        {
            //Kullanıcı işlemden vazgeçerse diye ek süre tanıdım.İptal edilirse OperationCanceledException bloğu çalışacak.
            await Task.Delay(2500, token);
            try
            {
                if (user == null)
                {
                    return IdentityResult.Failed(new IdentityError
                    {
                        Code = "userNull",
                        Description = "Kullanıcı bilgileri boş olamaz."

                    });
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    return IdentityResult.Failed(new IdentityError
                    {
                        Code = "passwordNull",
                        Description = "Parola bilgisi boş olamaz."
                    });
                }
                WebUserAccount webUserAccount = _mapper.Map<WebUserAccount>(user);
                webUserAccount.Guid = Guid.NewGuid().ToString();
                webUserAccount.CreatedID = _accessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "Empty";
                webUserAccount.CreatedDate = DateTime.Now;
                webUserAccount.CreatedIPAddress = "Empty";//todo: Düzenlenecek
                webUserAccount.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
                IdentityResult result = await _userManager.CreateAsync(webUserAccount, password);
                return result;
            }
            catch (OperationCanceledException oce)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "Canceled",
                    Description = $"{oce.Message}\nİşlem tarafınızdan iptal edilmiştir!"
                });
            }
            catch (Exception ex)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "Unknown",
                    Description = $"{ex.Message}\nBilinmeyen bir sorun oluştu.Lütfen tekrar deneyin!!"
                });
            }
        }
        /// <summary>
        /// Kullanıcı bilgilerini güncellemek için kullanın.Ek özellikler de güncellemeye tabiidir.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<IdentityResult> UpdateUserAsync(WebUserAccountRequestDTO user, CancellationToken token)
        {
            await Task.Delay(2500, token);
            try
            {
                if (user == null)
                {
                    return IdentityResult.Failed(new IdentityError
                    {
                        Code = "userNull",
                        Description = "Kullanıcı bilgileri boş olamaz."
                    });
                }
                WebUserAccount? webUserAccount = await _repository.GetByIdAsync(user.Id);
                if (webUserAccount == null)
                {
                    return IdentityResult.Failed(new IdentityError
                    {
                        Code = "Empty",
                        Description = "Id bilgisine uygun kullanıcı bulunamadı!"
                    });
                }
                _mapper.Map(user, webUserAccount);
                webUserAccount.SecurityStamp = Guid.NewGuid().ToString();
                webUserAccount.IsUpdated = true;
                webUserAccount.UpdatedDate = DateTime.Now;
                webUserAccount.UpdatedID = _accessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                webUserAccount.UpdatedIPAddress = _accessor.HttpContext?.Request?.Headers["X-Forwarded-For"].FirstOrDefault()
             ?? _accessor.HttpContext?.Connection?.RemoteIpAddress?.MapToIPv4().ToString();
                IdentityResult result = await _userManager.UpdateAsync(webUserAccount);
                return result;
            }
            catch (OperationCanceledException oce)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "Canceled",
                    Description = $"{oce.Message}\nİşlem tarafınızdan iptal edilmiştir!"
                });
            }
            catch (Exception ex)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "Unknown",
                    Description = $"{ex.Message}\nBilinmeyen bir sorun oluştu.Lütfen tekrar deneyin!!"
                });
            }
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
