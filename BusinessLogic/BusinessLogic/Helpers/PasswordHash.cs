using BCrypt.Net;

namespace BusinessLogic.Helpers
{
    public class PasswordHash
    {
        /// <summary>
        /// Kullanıcı şifresini veritabanına hashleyerek kaydetmek için kullanılır.
        /// </summary>
        public static string HashPassword(string passWord)
        {
            var hashPassword = BCrypt.Net.BCrypt.HashPassword(passWord);
            return hashPassword;
        }
        /// <summary>
        /// Kullanıcınin Login ekranında gönderdiği şifre bilgisinin doğruluğunu kontrol eder.
        /// </summary>
        /// <param name="hashPassword"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public static bool ValidPassword(string hashPassword,string passWord)
        { 
           return BCrypt.Net.BCrypt.Verify(hashPassword,passWord);
        }
    }
}
