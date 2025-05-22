using AutoMapper;
using AutoMapper.QueryableExtensions;
using Azure;
using BusinessLogic.DTOs.OperationResult;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Enums;
using BusinessLogic.Helpers;
using BusinessLogic.Services.Abstracts.WebUsers.Identity;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Repositories.Abstracts.WebUserR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services.Concretes.WebUsers.Identity
{
    public class IdentityService : IRoleService, ISignInService, IUserService
    {
        private readonly UserManager<WebUserAccount> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly SignInManager<WebUserAccount> _signInManager;
        private readonly IMapper _mapper;
        private readonly IWebUserAccountRepository _repository;
        public IdentityService(UserManager<WebUserAccount> userManager, RoleManager<IdentityRole<int>> roleManager, SignInManager<WebUserAccount> signInManager, IWebUserAccountRepository repository, IMapper mapper, IHttpContextAccessor accessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _repository = repository;
        }
        /// <summary>
        /// Filtrelemeler doğrultusunda kullanıcıya ilgili hesapları dönecek olan metot.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultDTO<WebUserAccountResponseDTO, WebUserAccountFilterModel>> DynamicWebUserFilter(ResultDTO<WebUserAccountResponseDTO, WebUserAccountFilterModel> filterModel)
        {
            try
            {
                var result = new ResultDTO<WebUserAccountResponseDTO, WebUserAccountFilterModel>();
                if (filterModel.DynamicFilter == null)
                {
                    result.NotificationType = new NotificationType { ResultType = Enums.Notifications.Null, Description = "Kriter belirtilmemiş!" };
                }
                else
                {
                    result.List = await _repository.GetDynamicFilteredEntities(filterModel.DynamicFilter).ProjectTo<WebUserAccountResponseDTO>(_mapper.ConfigurationProvider).ToListAsync();
                    if (!result.List.Any())
                    {
                        result.NotificationType = new NotificationType { ResultType = Enums.Notifications.NullUser, Description = "Kriterlere uygun kullanıcı bulunamadı!!" };
                    }
                    result.NotificationType = new NotificationType { ResultType = Enums.Notifications.Success };
                }

                result.DynamicFilter = new WebUserAccountFilterModel();
                return result;
            }
            catch (Exception ex)
            {
                var result = new ResultDTO<WebUserAccountResponseDTO, WebUserAccountFilterModel>();
                result.NotificationType = new NotificationType
                {
                    ResultType = Enums.Notifications.UnknownError,
                    Description = $"Bilinmeyen bir hata meydana geldi daha sonra tekrar deneyin!!\n{ex.Message}"
                };
                return result;
            }
        }
        /// <summary>
        /// Yeni bir kullanıcı kaydı için bu metodu kullanın.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<NotificationType> CreateUserAsync(WebUserAccountRequestDTO user, string password, CancellationToken token)
        {
            //Kullanıcı işlemden vazgeçerse diye ek süre tanıdım.İptal edilirse OperationCanceledException bloğu çalışacak.
            await Task.Delay(2500, token);
            try
            {
                if (user == null)
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.NullPassWord, Description = "Kullanıcı şifresi boş olamaz!" };
                }

                var existingUser = await _userManager.FindByNameAsync(user.UserName);
                if (existingUser != null)
                    return new NotificationType { ResultType = Enums.Notifications.ExistingUser, Description = "Kullanıcı adı zaten var!" };
                WebUserAccount webUserAccount = _mapper.Map<WebUserAccount>(user);

                //Bu noktada şifrenin kriterlere uygunluğunu Identity Kütüphanesinin metotlarıyla kontrol ediyoruz.
                var pwdValidator = _userManager.PasswordValidators;
                foreach (var validator in pwdValidator)
                {
                    var pwdResult = await validator.ValidateAsync(_userManager, webUserAccount, password);
                    if (!pwdResult.Succeeded)
                    {
                        return new NotificationType { ResultType = Enums.Notifications.WrongPassword, Description = "Şifre Kriterlere uygun değil!" };
                    }
                }
                webUserAccount.Guid = Guid.NewGuid().ToString();
                webUserAccount.CreatedDate = DateTime.Now;
                webUserAccount.CreatedID = UniqueIdentify.GetUserID();
                webUserAccount.CreatedIPAddress = IPAdress.GetIpAdress();
                webUserAccount.PasswordHash = PasswordHash.HashPassword(password);
                webUserAccount.LockoutEnabled = false;

                IdentityResult result = await _userManager.CreateAsync(webUserAccount, password);
                if (result.Succeeded)
                    return new NotificationType { ResultType = Enums.Notifications.Success, Description = "Kullanıcı başarıyla kaydedildi!" };

                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = "Kullanıcı kaydedilirken bilinmeyen bir hata oluştu!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationType { ResultType = Enums.Notifications.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Kullanıcının aktiflik durumunu pasife çekmek için kullanın.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<NotificationType> DeleteUserAsync(int ID)
        {
            try
            {
                var deletedUser = await _repository.GetByIdAsync(ID);
                if (deletedUser == null) new NotificationType
                { ResultType = Enums.Notifications.NullUser, Description = "Id bilgisi ile eşleşen kullanıcı bulunamadı !!" };
                if (deletedUser != null) deletedUser.Status = DataStatus.Passive;
                return new NotificationType { ResultType = Enums.Notifications.Success, Description = "Kullanıcı pasif duruma getirildi!" };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = "Kullanıcı pasif duruma getirilemedi. Lütfen tekrar deneyin!\n" + ex.Message };
            }
        }
        /// <summary>
        /// Kullanıcıyı veritabanından tamamen silmek için kullanın.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<NotificationType> DestroyUserAsync(int ID)
        {
            var destroyedUser = await _repository.GetByIdAsync(ID);

            if (destroyedUser == null) return new NotificationType
            { ResultType = Enums.Notifications.NullUser, Description = "Id bilgisi ile eşleşen kullanıcı bulunamadı !!" };

            if (destroyedUser.Status != DataStatus.Passive) return new NotificationType { ResultType = Enums.Notifications.NotPassive, Description = "Kullanıcı veritabanından silinmeden önce pasif hale getirilmelidir!!" };

            if (destroyedUser != null && destroyedUser.Status == DataStatus.Passive)
                await _repository.DestroyAsync(destroyedUser.Id);
            return new NotificationType
            { ResultType = Enums.Notifications.Success, Description = "kullanıcı başarıyla veritabanından silindi!" };

        }
        /// <summary>
        /// Kullanıcı bilgilerini güncellemek için kullanın.Ek özellikler de güncellemeye tabiidir.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<NotificationType> UpdateUserAsync(WebUserAccountRequestDTO user, CancellationToken token)
        {
            await Task.Delay(2500, token);
            try
            {
                if (user == null)
                {
                    return new NotificationType { ResultType = Enums.Notifications.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                WebUserAccount? webUserAccount = await _repository.GetByIdAsync(user.Id);
                if (webUserAccount == null)
                {
                    return new NotificationType { ResultType = Enums.Notifications.IDNotFound, Description = "Id ile eşleşen kullanıcı yok!" };
                }
                var existingUser = _userManager.FindByNameAsync(user.UserName);
                if (existingUser != null)
                    return new NotificationType { ResultType = Enums.Notifications.ExistingUser, Description = "Kullanıcı adı zaten var!" };

                _mapper.Map(user, webUserAccount);
                webUserAccount.SecurityStamp = Guid.NewGuid().ToString();
                webUserAccount.IsUpdated = true;
                webUserAccount.UpdatedDate = DateTime.Now;
                webUserAccount.UpdatedID = UniqueIdentify.GetUserID();
                webUserAccount.UpdatedIPAddress = IPAdress.GetIpAdress();
                IdentityResult result = await _userManager.UpdateAsync(webUserAccount);
                if (result.Succeeded)
                    return new NotificationType { ResultType = Enums.Notifications.Success, Description = "Kullanıcı başarıyla güncellendi!" };

                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = "Bilinmeyen bir hata oluştu!" };

            }
            catch (OperationCanceledException oce)
            {
                return new NotificationType { ResultType = Enums.Notifications.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
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
        public async Task<NotificationType> AddToRoleAsync(WebUserAccount user, string role, CancellationToken token)
        {
            try
            {
                await Task.Delay(2500);

                if (user == null)
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(role))
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.Null, Description = "Kullanıcı rol ismi boş olamaz!" };
                }

                // Kullanıcıya rol ekle
                var result = await _userManager.AddToRoleAsync(user, role);

                if (result.Succeeded)
                {
                    return new NotificationType { ResultType = Enums.Notifications.Success, Description = "Rol başarıyla eklendi!" };
                }
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = "Bilinmeyen bir hata oluştu!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationType { ResultType = Enums.Notifications.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }

        }
        /// <summary>
        /// İlgili kullanıcının seçili rolünü siler.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public async Task<NotificationType> RemoveFromRoleAsync(WebUserAccount user, string role, CancellationToken token)
        {

            try
            {
                await Task.Delay(2500);
                if (user == null)
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(role))
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.Null, Description = "Kullanıcı silinecek rolü boş olamaz!" };
                }
                var result = await _userManager.RemoveFromRoleAsync(user, role);

                if (result.Succeeded)
                {
                    return new NotificationType { ResultType = Enums.Notifications.Success, Description = "Rol başarıyla silindi!" };
                }
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = "Bilinmeyen bir hata oluştu!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationType { ResultType = Enums.Notifications.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }

        }
        /// <summary>
        /// İlgili kullanıcının aranan role sahip olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public async Task<NotificationType> IsInRoleAsync(WebUserAccount user, string role)
        {
            try
            {
                if (user == null)
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.NullUser, Description = "Kullanıcı bilgileri boş olamaz!" };
                }
                if (string.IsNullOrWhiteSpace(role))
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.Null, Description = "Kullanıcı aranacak rolü boş olamaz!" };
                }
                bool? x = await _userManager.IsInRoleAsync(user, role);
                if (x == true)
                    return new NotificationType { ResultType = Enums.Notifications.Success };
                return new NotificationType { ResultType = Enums.Notifications.Null };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// İlgili rolün var olup olmadığını sorgular.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<NotificationType> RoleExistsAsync(string roleName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roleName))
                {
                    return new NotificationType
                    { ResultType = Enums.Notifications.Null, Description = "Aranacak Kullanıcı rolü boş olamaz!" };
                }
                var result = await _roleManager.RoleExistsAsync(roleName);
                if (result == true)
                    return new NotificationType { ResultType = Enums.Notifications.Success };
                return new NotificationType { ResultType = Enums.Notifications.Error };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }
        }
        /// <summary>
        /// Yeni bir rol yaratır.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<NotificationType> CreateRoleAsync(string roleName, CancellationToken token)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roleName))
                    return new NotificationType { ResultType = Enums.Notifications.Null, Description = "Rol adı boş olamaz!" };

                var result = await _roleManager.CreateAsync(new IdentityRole<int> { Name = roleName });
                if (result.Succeeded)
                    return new NotificationType { ResultType = Enums.Notifications.Success, Description = "Rol başarıyla oluşturuldu!" };
                return new NotificationType { ResultType = Enums.Notifications.Error, Description = "Hata meydana geldi!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationType { ResultType = Enums.Notifications.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
            }

        }
        /// <summary>
        /// Rolü siler.
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<NotificationType> DeleteRoleAsync(string roleName, CancellationToken token)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(roleName))
                    return new NotificationType { ResultType = Enums.Notifications.Null, Description = "Rol adı boş olamaz!" };

                var role = await _roleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    return new NotificationType { ResultType = Enums.Notifications.Error, Description = "Rol veritabanında bulunamadı!" };
                }
                var result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return new NotificationType { ResultType = Enums.Notifications.Success, Description = "Rol başarıyla silindi!" };
                return new NotificationType { ResultType = Enums.Notifications.Error, Description = "Hata meydana geldi!" };
            }
            catch (OperationCanceledException oce)
            {
                return new NotificationType { ResultType = Enums.Notifications.CancelledByUser, Description = $"Kullanıcı tarafından işlem iptal edildi!\n{oce.Message}" };
            }
            catch (Exception ex)
            {
                return new NotificationType { ResultType = Enums.Notifications.UnknownError, Description = $"Bilinmeyen bir hata oluştu!\n{ex.Message}" };
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
                return _mapper.Map<List<WebUserAccountResponseDTO>>(await _repository.GetDynamicFilteredEntities(new WebUserAccountFilterModel { Status = DataStatus.Active }).ToListAsync());
                //Bir sorun olursa tüm aktifleri döndür
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

        public async Task<NotificationType> PasswordSignInAsync(string? userName, string? password, bool isPersistent, bool lockoutOnFailure)
        {
            try
            {
                SignInResult result = await _signInManager
                .PasswordSignInAsync(userName, password, isPersistent = false, lockoutOnFailure = false);
                //Uygulamada yanlış deneme sonrası şifre bloklama veya beni hatırla bulunmayacak.
                if (result.IsLockedOut)
                    return new NotificationType { ResultType = Enums.Notifications.LockedOut, Description = "Hesap kilitlenmiş !!" };
                if (result.Succeeded)
                    return new NotificationType { ResultType = Enums.Notifications.Success };
                return new NotificationType { ResultType = Enums.Notifications.Error, Description = "Beklenmeyen bir hata meydana geldi!" };
            }
            catch (Exception ex)
            {
                return new NotificationType
                {
                    ResultType = Enums.Notifications.UnknownError,
                    Description = $"Bilinmeyen bir hata oluştu.Lütfen tekrar deneyin!\n {ex.Message}"
                };
            }
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<NotificationType> CanSignInAsync(WebUserAccount user)
        {
            try
            {
                bool x = await _signInManager.CanSignInAsync(user);
                if (x)
                    return new NotificationType() { ResultType = Enums.Notifications.Success };
                return new NotificationType() { ResultType = Enums.Notifications.Error, Description = "Kullanıcı giriş yapamaz! Destek Birimi ile iletişimi geçin" };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
