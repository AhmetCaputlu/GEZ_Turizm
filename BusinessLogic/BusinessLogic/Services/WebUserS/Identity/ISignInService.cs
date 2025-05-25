using BusinessLogic.OperationResult;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Services.Abstracts.WebUsers.Identity
{
    public interface ISignInService
    {
        /// <summary>
        /// Kullanıcıyı şifresiyle giriş yapabilir mi ? Beni hatırla ve hesabı kitlemekle alakalı seçimlerde yapıldı.
        /// Döndüreceği sonuç başarılı,değil veya 2FA gerekli gibi ancak 2FA şimdilik devre dışı.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="isPersistent"></param>
        /// <param name="lockoutOnFailure"></param>
        /// <returns></returns>
        Task<NotificationDTO> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure);
        
        /// <summary>
        /// Güvenli çıkış seçeneği.Cookie, claim vb. bilgiler silinir.
        /// </summary>
        /// <returns></returns>
        Task SignOutAsync();

        /// <summary>
        /// Kullanıcının Status bilgisine göre giriş izni/reddi verebilirsin.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<NotificationDTO> CanSignInAsync(WebUserAccount user);
    }
}
