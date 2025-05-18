using System.Data;
using System.Security.Claims;
using AutoMapper;
using Bogus;
using BusinessLogic.DTOs.OperationResult;
using BusinessLogic.DTOs.SignIn_SignUpDTOs;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Enums;
using BusinessLogic.Helpers;
using BusinessLogic.Services.Abstracts.WebUsers.Identity;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
        public IdentityService(UserManager<WebUserAccount> userManager, RoleManager<IdentityRole<int>> roleManager, SignInManager<WebUserAccount> signInManager, IGenericRepository<WebUserAccount> repository, IMapper mapper, IHttpContextAccessor accessor)
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
        public async Task<ResultDTO> CreateUserAsync(WebUserAccountRequestDTO user, string password, CancellationToken token)
        {
            //Kullanıcı işlemden vazgeçerse diye ek süre tanıdım.İptal edilirse OperationCanceledException bloğu çalışacak.
            await Task.Delay(2500, token);
            try
            {
                if (user == null)
                {
                    return new ResultDTO
                    { ResultType = ResultType.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    return new ResultDTO
                    { ResultType = ResultType.NullPassWord, Description = "Kullanıcı şifresi boş olamaz!" };
                }

                var existingUser = await _userManager.FindByNameAsync(user.UserName);
                if (existingUser != null)
                    return new ResultDTO { ResultType = ResultType.ExistingUser, Description = "Kullanıcı adı zaten var!" };
                WebUserAccount webUserAccount = _mapper.Map<WebUserAccount>(user);
                var pwdValidator = _userManager.PasswordValidators;
                foreach (var validator in pwdValidator)
                {
                    var pwdResult = await validator.ValidateAsync(_userManager, webUserAccount, password);
                    if (!pwdResult.Succeeded)
                    {
                        return new ResultDTO { ResultType = ResultType.WrongPassword, Description = "Şifre Kriterlere uygun değil!" };
                    }
                }
                webUserAccount.Guid = Guid.NewGuid().ToString();
                webUserAccount.CreatedID = UniqueIdentify.GetUserID();
                webUserAccount.CreatedDate = DateTime.Now;
                webUserAccount.CreatedIPAddress = IPAdress.GetIpAdress();
                webUserAccount.PasswordHash = PasswordHash.HashPassword(password);

                IdentityResult result = await _userManager.CreateAsync(webUserAccount, password);
                if (result.Succeeded)
                    return new ResultDTO { ResultType = ResultType.Success, Description = "Kullanıcı başarıyla kaydedildi!" };

                return new ResultDTO { ResultType = ResultType.UnknownError, Description = "Bilinmeyen bir hata oluştu!" };
            }
            catch (OperationCanceledException oce)
            {
                return new ResultDTO { ResultType = ResultType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Kullanıcı bilgilerini güncellemek için kullanın.Ek özellikler de güncellemeye tabiidir.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ResultDTO> UpdateUserAsync(WebUserAccountRequestDTO user, CancellationToken token)
        {
            await Task.Delay(2500, token);
            try
            {
                if (user == null)
                {
                    return new ResultDTO { ResultType = ResultType.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                WebUserAccount? webUserAccount = await _repository.GetByIdAsync(user.Id);
                if (webUserAccount == null)
                {
                    return new ResultDTO { ResultType = ResultType.IDNotFound, Description = "Id ile eşleşen kullanıcı yok!" };
                }
                var existingUser = _userManager.FindByNameAsync(user.UserName);
                if (existingUser != null)
                    return new ResultDTO { ResultType = ResultType.ExistingUser, Description = "Kullanıcı adı zaten var!" };

                _mapper.Map(user, webUserAccount);
                webUserAccount.SecurityStamp = Guid.NewGuid().ToString();
                webUserAccount.IsUpdated = true;
                webUserAccount.UpdatedDate = DateTime.Now;
                webUserAccount.UpdatedID = UniqueIdentify.GetUserID();
                webUserAccount.UpdatedIPAddress = IPAdress.GetIpAdress();
                IdentityResult result = await _userManager.UpdateAsync(webUserAccount);
                if (result.Succeeded)
                    return new ResultDTO { ResultType = ResultType.Success, Description = "Kullanıcı başarıyla güncellendi!" };

                return new ResultDTO { ResultType = ResultType.UnknownError, Description = "Bilinmeyen bir hata oluştu!" };

            }
            catch (OperationCanceledException oce)
            {
                return new ResultDTO { ResultType = ResultType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// İlgili kullanıcının rollerini listeler. 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<IList<string>> GetUserRolesAsync(int Id)
        {
            try
            {
                WebUserAccount? webUserAccount = await _repository.GetByIdAsync(Id);
                if (webUserAccount != null)
                {
                    var roles = await _userManager.GetRolesAsync(webUserAccount);
                    if (roles.Any())
                        return roles.ToList();
                    return new List<string> { "Kullanıcının rolü yok!" };
                }
                return new List<string>
            {
                "Kullanıcı bulunamadı!!"
            };
            }
            catch (Exception ex)
            {
                return new List<string> { "Bilinmeyen bir hata oluştu", ex.Message };
            }
        }
        /// <summary>
        /// İlgili kullanıcıya yeni bir rol ekler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<ResultDTO> AddToRoleAsync(WebUserAccount user, string role, CancellationToken token)
        {
            try
            {
                await Task.Delay(2500);

                if (user == null)
                {
                    return new ResultDTO
                    { ResultType = ResultType.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(role))
                {
                    return new ResultDTO
                    { ResultType = ResultType.Null, Description = "Kullanıcı rol ismi boş olamaz!" };
                }

                // Kullanıcıya rol ekle
                var result = await _userManager.AddToRoleAsync(user, role);

                if (result.Succeeded)
                {
                    return new ResultDTO { ResultType = ResultType.Success, Description = "Rol başarıyla eklendi!" };
                }
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = "Bilinmeyen bir hata oluştu!" };
            }
            catch (OperationCanceledException oce)
            {
                return new ResultDTO { ResultType = ResultType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }

        }
        /// <summary>
        /// İlgili kullanıcının seçili rolünü siler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public async Task<ResultDTO> RemoveFromRoleAsync(WebUserAccount user, string role, CancellationToken token)
        {

            try
            {
                await Task.Delay(2500);
                if (user == null)
                {
                    return new ResultDTO
                    { ResultType = ResultType.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(role))
                {
                    return new ResultDTO
                    { ResultType = ResultType.Null, Description = "Kullanıcı silinecek rolü boş olamaz!" };
                }
                var result = await _userManager.RemoveFromRoleAsync(user, role);

                if (result.Succeeded)
                {
                    return new ResultDTO { ResultType = ResultType.Success, Description = "Rol başarıyla silindi!" };
                }
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = "Bilinmeyen bir hata oluştu!" };
            }
            catch (OperationCanceledException oce)
            {
                return new ResultDTO { ResultType = ResultType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }

        }
        /// <summary>
        /// İlgili kullanıcının aranan role sahip olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public async Task<ResultDTO> IsInRoleAsync(WebUserAccount user, string role)
        {
            try
            {
                if (user == null)
                {
                    return new ResultDTO
                    { ResultType = ResultType.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(role))
                {
                    return new ResultDTO
                    { ResultType = ResultType.Null, Description = "Kullanıcı aranacak rolü boş olamaz!" };
                }
                bool? x = await _userManager.IsInRoleAsync(user, role);
                if (x == true)
                    return new ResultDTO { ResultType = ResultType.Success };
                return new ResultDTO { ResultType = ResultType.Null };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// İlgili rolün var olup olmadığını sorgular.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<ResultDTO> RoleExistsAsync(string roleName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roleName))
                {
                    return new ResultDTO
                    { ResultType = ResultType.Null, Description = "Kullanıcı aranacak rolü boş olamaz!" };
                }
                var result = await _roleManager.RoleExistsAsync(roleName);
                if (result == true)
                    return new ResultDTO { ResultType = ResultType.Success };
                return new ResultDTO { ResultType = ResultType.Error };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Yeni bir rol yaratır.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<ResultDTO> CreateRoleAsync(string roleName, CancellationToken token)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roleName))
                    return new ResultDTO { ResultType = ResultType.Null, Description = "Rol adı boş olamaz!" };

                var result = await _roleManager.CreateAsync(new IdentityRole<int> { Name = roleName });
                if (result.Succeeded)
                    return new ResultDTO { ResultType = ResultType.Success, Description = "Rol başarıyla oluşturuldu!" };
                return new ResultDTO { ResultType = ResultType.Error, Description = "Hata meydana geldi!" };
            }
            catch (OperationCanceledException oce)
            {
                return new ResultDTO { ResultType = ResultType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }

        }
        /// <summary>
        /// Rolü siler.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<ResultDTO> DeleteRoleAsync(string roleName, CancellationToken token)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roleName))
                    return new ResultDTO { ResultType = ResultType.Null, Description = "Rol adı boş olamaz!" };

                var role = await _roleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    return new ResultDTO { ResultType = ResultType.Error, Description = "Rol veritabanında bulunamadı!" };
                }
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return new ResultDTO { ResultType = ResultType.Success, Description = "Rol başarıyla silindi!" };
                return new ResultDTO { ResultType = ResultType.Error, Description = "Hata meydana geldi!" };
            }
            catch (OperationCanceledException oce)
            {
                return new ResultDTO { ResultType = ResultType.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new ResultDTO { ResultType = ResultType.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// İlgili role sahip tüm kullanıcıları döndürür.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<List<WebUserAccountResponseDTO>> GetUsersInRoleAsync(string roleName)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(roleName))
                {
                    var originalList = await _userManager.GetUsersInRoleAsync(roleName);
                    if (originalList.Any())
                    {
                        var responseList = _mapper.Map<IList<WebUserAccountResponseDTO>>(originalList);
                        return responseList.ToList();
                    }
                }
                return _mapper.Map<List<WebUserAccountResponseDTO>>(await _repository.GetDynamicFilteredEntities(firstCreatedDate: new DateTime(01, 01, 1900), secondCreatedDate: DateTime.Now).ToListAsync());
                //Bir sorun olursa herkesi döndür
            }
            catch (Exception)
            {
                return new List<WebUserAccountResponseDTO>();
                //Sorun olursa boş liste döndür.
            }
        }
        /// <summary>
        /// Tüm rolleri döndürür.
        /// </summary>
        /// <returns></returns>
        public async Task<List<IdentityRole<int>>> GetAllRolesAsync()
        {
            try
            {
                return await _roleManager.Roles.ToListAsync();
            }
            catch (Exception)
            {
                return new List<IdentityRole<int>>();
            }
        }

        public async Task<ResultDTO> PasswordSignInAsync(string? userName, string? password, bool isPersistent, bool lockoutOnFailure)
        {
            try
            {
                SignInResult result = await _signInManager
                .PasswordSignInAsync(userName, password, isPersistent = false, lockoutOnFailure = false);
                //Uygulamada yanlış deneme sonrası şifre bloklama veya beni hatırla bulunmayacak.
                if (result.IsLockedOut)
                    return new ResultDTO { ResultType = ResultType.LockedOut, Description = "Hesap kilitlenmiş !!" };
                if (result.Succeeded)
                    return new ResultDTO { ResultType = ResultType.Success };
                return new ResultDTO { ResultType = ResultType.Error, Description = "Beklenmeyen bir hata meydana geldi!" };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    ResultType = ResultType.UnknownError,
                    Description = $"Bilinmeyen bir hata oluştu.Lütfen tekrar deneyin!\n {ex.Message}"
                };
            }
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<ResultDTO> CanSignInAsync(WebUserAccount user)
        {
            try
            {
                bool x = await _signInManager.CanSignInAsync(user);
                if (x)
                    return new ResultDTO() { ResultType = ResultType.Success };
                return new ResultDTO() { ResultType = ResultType.Error, Description = "Kullanıcı giriş yapamaz! Destek Birimi ile iletişimi geçin" };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
