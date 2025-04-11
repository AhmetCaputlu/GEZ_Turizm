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
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    UserName = faker.Name.FirstName(),
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(faker.Lorem.Word()),
                    Email = faker.Internet.Email(),
                    PhoneNumber = faker.Phone.PhoneNumber("05#########"),
                    CountryId = faker.Random.Int(1, 5),
                    LockoutEnabled = false,
                    LockoutEnd = DateTime.Now.AddDays(7)
                };
                webUserAccount.NormalizedUserName = webUserAccount.UserName.ToUpper();
                webUserAccount.NormalizedEmail = webUserAccount.Email.ToUpper();
                webUserAccounts.Add(webUserAccount);
            }
            return webUserAccounts;
        }
    }
}




