using BCrypt.Net;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Entities.Enums;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.WebUsers
{
    internal class WebUserAccountSeedData
    {
        internal static List<WebUserAccount> GetUserAccounts(int count)
        {
            List<WebUserAccount> webUserAccounts = new List<WebUserAccount>();
            for (int i = 0; i < count; i++)
            {
                WebUserAccount webUserAccount = new WebUserAccount
                {

                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),//Başlangıç verilerimiz rastgele olsun
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = $"CreatedIPAdress {i}",
                    UserName = $"UserName {i}",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword($"HashPassword {i}"),
                    Email = $"Email {i}",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    PhoneNumber = $"PNumber {i}",
                    CountryId = RandomNavId.GetNavIdMax10(),
                };
                webUserAccount.NormalizedUserName = webUserAccount.UserName.ToUpper();
                webUserAccount.NormalizedEmail = webUserAccount.Email.ToUpper();
                webUserAccounts.Add(webUserAccount);
            }
            return webUserAccounts;
        }
    }
}
