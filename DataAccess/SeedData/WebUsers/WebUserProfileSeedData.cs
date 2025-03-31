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
                    PhoneNumber = faker.Phone.PhoneNumber("05#########"),
                    Address = faker.Address.FullAddress(),
                    PhotoPath = faker.Person.Website,
                    TCN_Passport = faker.Random.ReplaceNumbers("###########"),
                    Email = faker.Person.Email,
                    UpdatedDate = RandomDatetime.GetProfileUpdateDateTime()
                };
                webUserProfiles.Add(webUserProfile);
            }
            return webUserProfiles;
        }
    }
}
