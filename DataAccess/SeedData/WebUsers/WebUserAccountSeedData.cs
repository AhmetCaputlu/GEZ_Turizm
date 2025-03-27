using BCrypt.Net;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.Entities.Enums;
using DataAccess.SeedData.Randoms;
using Bogus;

namespace DataAccess.SeedData.WebUsers
{
    internal class WebUserAccountSeedData
    {
        internal static List<WebUserAccount> GetUserAccounts(int count)
        {
            Faker faker = new Faker();
            List<WebUserAccount> webUserAccounts = new List<WebUserAccount>();
            for (int i = 0; i < count; i++)
            {
                WebUserAccount webUserAccount = new WebUserAccount
                {

                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),//Başlangıç verilerimiz rastgele olsun
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    UserName = faker.Name.FirstName(),
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword($"HashPassword {i}"),
                    Email = faker.Internet.Email(),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    PhoneNumber = faker.Phone.PhoneNumber("05#########"),
                    CountryId = RandomNavId.GetNavIdMax5(),
                };
                webUserAccount.NormalizedUserName = webUserAccount.UserName.ToUpper();
                webUserAccount.NormalizedEmail = webUserAccount.Email.ToUpper();
                webUserAccounts.Add(webUserAccount);
            }
            return webUserAccounts;
        }
    }
}




