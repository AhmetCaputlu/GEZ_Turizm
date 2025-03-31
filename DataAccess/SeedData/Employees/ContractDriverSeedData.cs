using Bogus;
using Bogus.Extensions.UnitedKingdom;
using DataAccess.Entities.Models.Employees;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Employees
{
    internal class ContractDriverSeedData
    {
        internal static List<ContractDriver> GetContractDrivers(int count)
        {
            List<ContractDriver> contractDrivers = new List<ContractDriver>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ContractDriver contractDriver = new ContractDriver
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
                    DriverLicense = RandomEnum.GetRandomDriverLicense(),
                    SubContractWorkerSupplierId = RandomNavId.GetNavIdMax5()
                };
                contractDrivers.Add(contractDriver);
            }
            return contractDrivers;
        }
    }
}