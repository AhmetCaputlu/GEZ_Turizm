using Bogus;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.OrderDetails
{
    internal class EventTicketOrderDetailSeedData
    {
        internal static List<EventTicketOrderDetail> GetEventTicketOrderDetails(int count)
        {
            List<EventTicketOrderDetail> eventTicketOrderDetails = new List<EventTicketOrderDetail>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                EventTicketOrderDetail eventTicketOrderDetail = new EventTicketOrderDetail
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
                    EventTicketId = faker.Random.Int(1, 50),
                    EventTicketOrderId = faker.Random.Int(1, 130)
                };
                eventTicketOrderDetails.Add(eventTicketOrderDetail);
            }
            return eventTicketOrderDetails;
        }
    }
}
