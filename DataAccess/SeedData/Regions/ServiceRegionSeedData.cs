using Bogus;
using DataAccess.Entities.Models.Regions;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Regions
{
    internal class ServiceRegionSeedData
    {
        internal static List<ServiceRegion> GetServiceRegions(int count)
        {
            List<ServiceRegion> serviceRegions = new List<ServiceRegion>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ServiceRegion region = new ServiceRegion
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    DistrictName = faker.Lorem.Word(),
                    ArrivalTime = TimeSpan.FromMinutes(faker.Random.Int(45, 180)),
                    TouristPopulation = faker.Random.Bool(),
                    HasAirport = faker.Random.Bool(),
                    HasHotelFacility = faker.Random.Bool(),
                    TransportVehicle = RandomEnum.GetRandomVehicleType()
                };
                serviceRegions.Add(region);
            }
            return serviceRegions;
        }
    }
}
