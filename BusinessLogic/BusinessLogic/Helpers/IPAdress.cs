using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Helpers
{
    public class IPAdress
    {
        private static IHttpContextAccessor? _accessor;

        public static void HttpConfigure(IHttpContextAccessor httpContextAccessor)
        {
            _accessor = httpContextAccessor;
        }
        public static string GetIpAdress()
        {
            // Proxy'den gelen IP varsa önce onu al
            var ip = _accessor?.HttpContext?.Request?.Headers["X-Forwarded-For"].FirstOrDefault();

            if (!string.IsNullOrEmpty(ip))
            {
                // Virgülle ayrılmışsa ilkini al (ilk IP genelde client'ın gerçek IP’si)
                var realIp = ip.Split(',').FirstOrDefault()?.Trim();
                if (!string.IsNullOrEmpty(realIp))
                    return realIp;
            }

            // Yoksa bağlantı IP'sini döndür (proxy yoksa bu yeterlidir)
            return _accessor?.HttpContext?.Connection?.RemoteIpAddress?.MapToIPv4().ToString()
                ?? "Unknown";
        }
    }
}
