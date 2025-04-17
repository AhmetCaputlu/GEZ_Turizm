using Bogus;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.OrderDetails
{
    internal class ActivityTicketOrderDetailSeedData
    {
        internal static List<ActivityTicketOrderDetail> GetActivityTicketOrderDetails(int count)
        {
            List<ActivityTicketOrderDetail> ActivityTicketOrderDetails = new List<ActivityTicketOrderDetail>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ActivityTicketOrderDetail ActivityTicketOrderDetail = new ActivityTicketOrderDetail
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    UnitPrice = faker.Random.Decimal(100m, 1200m),
                    Quantity = faker.Random.Byte(1, 4),
                    Discount = faker.Random.Decimal(0, 0.5m),
                    ActivityTicketId = faker.Random.Int(1, 5),
                    ActivityTicketOrderId = faker.Random.Int(1, 5)
                };
                ActivityTicketOrderDetails.Add(ActivityTicketOrderDetail);
            }
            return ActivityTicketOrderDetails;
        }
    }
}

