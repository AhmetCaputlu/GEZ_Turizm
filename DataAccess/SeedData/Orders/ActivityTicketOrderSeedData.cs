using Bogus;
using DataAccess.Entities.Models.Orders;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Orders
{
    internal class ActivityTicketOrderSeedData
    {
        internal static List<ActivityTicketOrder> GetActivityTicketOrders(int count)
        {
            List<ActivityTicketOrder> ActivityTicketOrders = new List<ActivityTicketOrder>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ActivityTicketOrder ActivityTicketOrder = new ActivityTicketOrder
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    Note = faker.Random.Words(4),
                    WebUserEmail = faker.Internet.Email(),
                    WebUserAccountId = faker.Random.Int(1, 5),
                    EmployeeId = faker.Random.Int(1, 5)
                };
                ActivityTicketOrders.Add(ActivityTicketOrder);
            }
            return ActivityTicketOrders;
        }
    }
}
