using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Helpers
{
    public class UniqueIdentify
    {
        private static IHttpContextAccessor? _accessor;
        public static void IDConfigure(IHttpContextAccessor httpContextAccessor)
        {
            _accessor = httpContextAccessor;
        }
        /// <summary>
        /// Http nesnesi ile işlemi gerçekleştiren kullanıcının ID adresini döndürür.Bulamazsa Unknown döndürür.
        /// </summary>
        /// <returns></returns>
        public static string GetUserID()
        {
            return _accessor?.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "Unknown";
        }
    }
}
