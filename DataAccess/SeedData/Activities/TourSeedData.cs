using Bogus;
using DataAccess.Entities.Models.Activities;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Activities
{
    internal class TourSeedData
    {
        internal static List<Tour> GetTours(int count)
        {
            List<Tour> tours = new List<Tour>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                Tour tour = new Tour
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    EventName = faker.Lorem.Word(),
                    StartDate = RandomDatetime.GetDateTime(),
                    Description = faker.Random.Words(8),
                    RegionId = RandomNavId.GetNavIdMax5(),
                    TourCategory = RandomEnum.GetRandomTour()
                };
                tour.EndDate =tour.StartDate.AddHours(RandomNavId.GetNavIdMax5());
                tours.Add(tour);
            }
            return tours;
        }
    }
}
