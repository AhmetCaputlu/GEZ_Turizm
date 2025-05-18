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
    }
}
