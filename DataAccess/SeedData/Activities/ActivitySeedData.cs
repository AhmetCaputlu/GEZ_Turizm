using Bogus;
using DataAccess.Entities.Models.Activities;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Activities
{
    internal class ActivitySeedData
    {
        internal static List<Activity> GetActivities(int count)
        {
            List<Activity> activities = new List<Activity>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                Activity activity = new Activity
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    ActivityName = faker.Lorem.Word(),
                    StartDate = RandomDatetime.GetDateTime(),
                    Description = faker.Random.Words(8),
                    RegionId = faker.Random.Int(1, 5),
                    ActivityCategory = RandomEnum.GetRandomActivityCategory()
                };
                activity.EndDate = activity.StartDate.AddHours(faker.Random.Byte(5, 12));
                activities.Add(activity);
            }
            return activities;
        }
    }
}
