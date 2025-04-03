using Bogus;
using DataAccess.Entities.Models.Vehicles;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Vehicles
{
    internal class VehicleSeedData
    {
        internal static List<Vehicle> GetVehicles(int count)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                Vehicle vehicle = new Vehicle
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    VehicleType = RandomEnum.GetRandomVehicleType(),
                    LicensePlate =
                    faker.Random.Int(1, 82) + " " + faker.Random.Char('a', 'z')
                    + faker.Random.Char('a', 'z') + " " + faker.Random.Int(1, 10000),
                    Model = faker.Vehicle.Model(),
                    Kilometer = faker.Random.Int(6000, 1000000),
                    Age = faker.Random.Int(1, 15),
                    Capacity = (short)faker.Random.Int(2, 100),
                    PurchaseDate = RandomDatetime.GetDateTime(),
                    MarketValue = faker.Random.Int(8000000, 22000000),
                    TourId = RandomNavId.GetNavIdMax5(),
                    EventId = RandomNavId.GetNavIdMax5(),
                };
                vehicles.Add(vehicle);
            }
            return vehicles;
        }
    }
}

