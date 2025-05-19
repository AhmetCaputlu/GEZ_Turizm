using Bogus;
using DataAccess.Entities.Models.Tickets;
using DataAccess.SeedData.Randoms;

namespace DataAccess.SeedData.PassTickets
{
    internal class ActivityPassTicketSeedData
    {
        internal static List<ActivityPassTicket> GetActivityPassTickets(int count)
        {
            List<ActivityPassTicket> ActivityPassTickets = new List<ActivityPassTicket>();
            Faker faker = new Faker();
            for (int i = 0; i < count; i++)
            {
                ActivityPassTicket ActivityPassTicket = new ActivityPassTicket
                {
                    Id = i + 1,
                    Guid = Guid.NewGuid().ToString(),
                    CreatedDate = RandomDatetime.GetDateTime(),
                    CreatedID = Guid.NewGuid().ToString(),
                    CreatedIPAddress = faker.Internet.IpAddress().ToString(),
                    Status = RandomEnum.GetRandomStatus(),
                    IsUpdated = faker.Random.Bool(0.2f),
                    Price = faker.Random.Decimal(100, 420),
                    CommissionRate = faker.Random.Byte(5, 20),
                    PartnerCompanyTransactionId = faker.Random.Int(1, 5)
                };
                ActivityPassTickets.Add(ActivityPassTicket);
            }
            return ActivityPassTickets;
        }
    }
}
