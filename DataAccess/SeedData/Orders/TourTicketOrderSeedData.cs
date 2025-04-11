using Bogus;
using DataAccess.Entities.Models.Orders;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.Orders
{
    internal class TourTicketOrderSeedData
    {
        internal static List<TourTicketOrder> GetTourTicketOrders(int count)
        {
            List<TourTicketOrder> tourTicketOrders = new List<TourTicketOrder>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                TourTicketOrder tourTicketOrder = new TourTicketOrder
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
                    EmployeeId = faker.Random.Int(1, 5),
                };
                tourTicketOrders.Add(tourTicketOrder);
            }
            return tourTicketOrders;
        }
    }
}
