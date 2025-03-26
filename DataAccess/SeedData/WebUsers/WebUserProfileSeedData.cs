using System.Security.Cryptography;
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
                WebUserProfile webUserProfile = new WebUserProfile
                {
                    WebUserAccountId = i + 1,
                    FirstName = $"FirstName {i}",
                    LastName = $"LastName {i}",
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
