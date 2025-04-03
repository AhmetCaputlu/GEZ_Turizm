using Bogus;
using DataAccess.Entities.Models.Regions;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Regions
{
    internal class ResidenceRegionSeedData
    {
        internal static List<ResidenceRegion> GetResidenceRegions(int count)
        {
            List<ResidenceRegion> residenceRegions = new List<ResidenceRegion>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ResidenceRegion region = new ResidenceRegion
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    DistrictName = faker.Lorem.Word(),
                    ArrivalTime = TimeSpan.FromMinutes(faker.Random.Int(45,180)),
                    TransportVehicle = RandomEnum.GetRandomVehicleType(),     
                };
                residenceRegions.Add(region);
            }
            return residenceRegions;
        }
    }
}
