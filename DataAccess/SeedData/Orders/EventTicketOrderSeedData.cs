using Bogus;
using DataAccess.Entities.Models.Orders;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Orders
{
    internal class EventTicketOrderSeedData
    {
        internal static List<EventTicketOrder> GetEventTicketOrders(int count)
        {
            List<EventTicketOrder> eventTicketOrders = new List<EventTicketOrder>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                EventTicketOrder eventTicketOrder = new EventTicketOrder
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
                eventTicketOrders.Add(eventTicketOrder);
            }
            return eventTicketOrders;
        }
    }
}
