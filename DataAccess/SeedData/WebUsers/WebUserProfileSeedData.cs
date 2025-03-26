using System.Security.Cryptography;
using Bogus;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.WebUsers;
using DataAccess.SeedData;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.WebUsers
{
    internal class WebUserProfileSeedData
    {
        internal static List<WebUserProfile> GetUserProfiles(int count)
        {
            List<WebUserProfile> webUserProfiles = new List<WebUserProfile>();
            for (int i = 0; i < count; i++)
            {
                Faker faker = new Faker();
                WebUserProfile webUserProfile = new WebUserProfile
                {
                    WebUserAccountId = i + 1,
                    FirstName =  faker.Name.FirstName() ,
                    LastName = faker.Name.LastName(),
                    Gender = RandomEnum.GetRandomGender(),
                    BirthDate = RandomDatetime.GetBirthDateTime(),
                    PhoneNumber = $"PNumber {i}",
                    Address = $"Adress {i}",
                    PhotoPath = $"PhotoPath {i}",
                    TCN_Passport = $"TCN {i}",
                    Email = $"Email {i}",
                    UpdatedDate = RandomDatetime.GetDateTime()
                };
                webUserProfiles.Add(webUserProfile);
            }
            return webUserProfiles;
        }
    }
}
