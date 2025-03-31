using Bogus;
using DataAccess.Entities.Models.Companies.Suppliers;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Companies.Suppliers
{
    internal class RentalVehicleSupplierSeedData
    {
        internal static List<RentalVehicleSupplier> GetRentalVehicleSuppliers(int count)
        {
            List<RentalVehicleSupplier> rentalVehicleSuppliers = new List<RentalVehicleSupplier>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                RentalVehicleSupplier supplier = new RentalVehicleSupplier
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
                rentalVehicleSuppliers.Add(supplier);
            }
            return rentalVehicleSuppliers;
        }
    }
}
