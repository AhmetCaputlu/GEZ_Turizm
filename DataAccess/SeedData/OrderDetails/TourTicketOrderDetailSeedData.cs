using Bogus;
using DataAccess.Entities.Models.OrderDetails;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.OrderDetails
{
    internal class TourTicketOrderDetailSeedData
    {
        internal static List<TourTicketOrderDetail> GetTourTicketOrderDetails(int count)
        {
            List<TourTicketOrderDetail> tourTicketOrderDetails = new List<TourTicketOrderDetail>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                TourTicketOrderDetail tourTicketOrderDetail = new TourTicketOrderDetail
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
                    TourTicketId = faker.Random.Int(1,50),
                    TourTicketOrderId = faker.Random.Int(1,130)
                };

                tourTicketOrderDetails.Add(tourTicketOrderDetail);
            }
            return tourTicketOrderDetails;
        }
    }
}
