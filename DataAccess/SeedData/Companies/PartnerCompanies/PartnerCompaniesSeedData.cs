using Bogus;
using DataAccess.Entities.Models.Companies.PartnerCompanies;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Companies.PartnerCompanies
{
    internal class PartnerCompaniesSeedData
    {
        internal static List<PartnerCompany> GetPartnerCompanies(int count)
        {
            List<PartnerCompany> partnerCompanies = new List<PartnerCompany>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                PartnerCompany company = new PartnerCompany
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    CompanyName = faker.Company.CompanyName(2) + " " + faker.Company.CompanySuffix(),
                    ContactName = faker.Name.FullName(),
                    ContactTitle = faker.Name.JobTitle(),
                    Email = faker.Internet.Email(),
                    PhoneNumber = faker.Phone.PhoneNumber("021########"),
                    Address = faker.Address.FullAddress(),
                    AcceptTickets = faker.Random.Bool(0.8f),
                    Debit = faker.Random.Decimal(10000, 100000),
                    Credit = faker.Random.Decimal(10000, 100000)
                };
                partnerCompanies.Add(company);
            }
            return partnerCompanies;
        }
    }
}
