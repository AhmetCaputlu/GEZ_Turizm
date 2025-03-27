using Bogus;
using Bogus.Extensions.UnitedKingdom;
using DataAccess.Entities.Models.Employees;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Employees
{
    internal class ContractTourGuideSeedData
    {
        internal static List<ContractTourGuide> GetContractTourGuides(int count)
        {
            List<ContractTourGuide> contractTourGuides = new List<ContractTourGuide>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ContractTourGuide contractTourGuide = new ContractTourGuide
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    Gender = RandomEnum.GetRandomGender(),
                    BirthDate = RandomDatetime.GetEmployeeBirthDateTime(),
                    Address = faker.Address.CountryOfUnitedKingdom(),
                    PhotoPath = faker.Internet.UrlWithPath(),
                    PhoneNumber = faker.Phone.PhoneNumber("05#########"),
                    Email = faker.Internet.Email(),
                    TCN_Passport = faker.Random.ReplaceNumbers("###########"),
                    HireDate = RandomDatetime.GetDateTime(),
                    Experience = RandomNavId.GetNavIdMax5(),
                    Language = RandomEnum.GetRandomLanguage(),
                };
                contractTourGuides.Add(contractTourGuide);
            }
            return contractTourGuides;
        }
    }
}
