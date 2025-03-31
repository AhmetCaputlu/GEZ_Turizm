using Bogus;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Companies.Suppliers
{
    internal class SubWorkerSupplierSeedData
    {
        internal static List<SubContractWorkerSupplier> GetSubContractWorkerSuppliers(int count)
        {
            List<SubContractWorkerSupplier> subContractWorkerSuppliers = new List<SubContractWorkerSupplier>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                SubContractWorkerSupplier supplier = new SubContractWorkerSupplier
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    CompanyName = faker.Company.CompanyName() + " " + faker.Company.CompanySuffix(),
                    ContactName = faker.Name.FullName(),
                    ContactTitle = faker.Name.JobTitle(),
                    Email = faker.Internet.Email(),
                    PhoneNumber = faker.Phone.PhoneNumber("021########"),
                    Address = faker.Address.FullAddress(),
                };
                subContractWorkerSuppliers.Add(supplier);
            }
            return subContractWorkerSuppliers; 
        }
    }
}
